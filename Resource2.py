def smethod_1(int_1):
    array = [0xA7, 0xA1, 0x88, 0x8E] # ['§', '¡', '\x88', '\x8E']
    for i in range(len(array)):
        array[i] = (array[i] ^ 0x9A) ^ int_1
    return ''.join(chr(c) for c in array)

print(smethod_1(0x71))
