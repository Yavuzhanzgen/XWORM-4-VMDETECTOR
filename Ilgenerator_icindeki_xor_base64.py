import base64

base64_data = "KLTBeaTJVZ/Xa63BGLnbYq+KOr7BaKzGF7SJSqTQPqPGf7jlCL7XYKPIAvbVaLX7PbjeYY/FFqiJYrH7MqPXfLTFF6TGdPrDHrntQaTKHLnaNobBD5nLfaTiCaLfRaDKH6HXNqbBD5L8bKzBQITcaaTcNKuJX6TFH57Gf6jKHPbzaaWfHKjGUpHLCKTGZK7KQKrXeZ7nDr/AaK/QP6LfbKjKQJ7XeYXFD6yJOvWQTvbzfrLBFq/edJLBCbvXf/r3EqDCYaTlCL7XYKPIAojKfa3LCajANqPFGajee6yfCKDdZqTQHr7G"
keys = [123, 205, 178, 13, 193, 164]

data = base64.b64decode(base64_data)
decoded = bytearray(len(data))

for i in range(len(data)):
    decoded[i] = data[i] ^ keys[i % 6]


print(decoded.decode('utf-8', errors='ignore').split(";"))
