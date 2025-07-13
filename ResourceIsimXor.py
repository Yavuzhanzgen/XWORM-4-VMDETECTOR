def smethod_1(int_0):
  
    array = list("\u001e\u0001\u0017\u0013") // dll içerisindeki sabit
    
    for i in range(len(array)):
        array[i] = chr((ord(array[i]) ^ ord('d')) ^ int_0) //yapilan islem
    
    return ''.join(array)

print(smethod_1(0)) 

//amac resource içindeki dosyanın ismini çekme bu dosya 2 katmanlı 
