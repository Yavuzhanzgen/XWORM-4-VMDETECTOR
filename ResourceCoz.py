import struct
from Crypto.Cipher import AES
from io import BytesIO
import zlib

def xor_data(data, key):
    return bytes([b ^ key[i % len(key)] for i, b in enumerate(data)])

def decrypt_file(input_path, output_path):
    with open(input_path, 'rb') as f:
        num = struct.unpack('<H', f.read(2))[0] 
        array = f.read(num)

        num2 = struct.unpack('<B', f.read(1))[0] 
        array2 = f.read(num2)  

        array = xor_data(array, array2) 

 
        inner = BytesIO(array)
        header = read_csharp_string(inner)  
        b = struct.unpack('<B', inner.read(1))[0] 
        b2 = struct.unpack('<B', inner.read(1))[0]  
        b3 = struct.unpack('<B', inner.read(1))[0]  
        num3 = struct.unpack('<B', inner.read(1))[0]  
        key_data = bytearray(inner.read(num3))

        if b3 >= 64:
            raise NotImplementedError("Public key block not supported in this script")

        cipher = AES.new(bytes(key_data), AES.MODE_CBC, array2)

        encrypted_data = f.read()
        decrypted_data = cipher.decrypt(encrypted_data)
      
        if (b & 1) != 0:
            decompressed_data = zlib.decompress(decrypted_data)
        else:
            decompressed_data = decrypted_data

        with open(output_path, 'wb') as out_file:
            out_file.write(decompressed_data)

def read_csharp_string(bio):
    length = struct.unpack('<B', bio.read(1))[0]
    if length == 0:
        return ''
    return bio.read(length).decode('utf-8', errors='ignore')

decrypt_file("LJce.bin", "LJce_bin_Cozuldu.bin")
