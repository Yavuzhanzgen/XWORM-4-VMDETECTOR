def decode_smethod_0(int_0, int_1, int_2):
    # int_0 işlemi
    int_0 -= 1
    int_0 = (int_0 + 1) ^ 1748792279 ^ 1706490100 ^ 1748792279

    # int_1 işlemi
    int_1 += 1
    num = int_2 & 0xFF
    int_2 ^= num
    num += 15
    int_1 = (int_1 - 1) ^ num ^ 796924165 ^ num

    # int_2 işlemi 
    int_2 = (int_2 | (num - 15)) ^ 1748792279

    return int_0, int_1, int_2


int_0 = 1740045316
int_1 = 629153291
int_2 = 1815897681

decoded = decode_smethod_0(int_0, int_1, int_2)
print("Decoded values:", decoded)
