sayi1 = 5
sayi2 = 3.5

print(type(sayi1))
print(type(sayi2))

# <class 'int'>
# <class 'float'>

# matematiksel işlemler : matematiksel bir değer döner.

# toplama       : " + "
# çıkartma      : " - "
# çarpma        : " * "
# bölme         : " / "
# tamsayı bölme : " // "
# kuvvet alma   : " ** "
# mutlak değer  : " abs "
# yuvarlama     : " round "

print(3+4)                  # / 7
print(3-4)                  # / -1
print(3*4)                  # / 12
print(3/4)                  # / 0.75
print(3//4)                 # / 0
print(3**4)                 # / 81
print(abs(-3))              # / 3
print(round(22/7,2))        # / 3.14 
print(round(22/7,5))        # / 3.14286


# karşılaştırma operatörleri : True ya da False döner

# Eşittir       : " == "
# Büyüktür      : " > "
# Büyük Eşittir : " >= "
# Küçüktür      : " < "
# Küçük Eşittir : " <= " 
# Eşit Değildir : " != "

sayi3 = 21
sayi4 = 34

print(sayi3 == sayi4)   # / False
print(sayi3 > sayi4)    # / False
print(sayi3 >= sayi4)   # / False
print(sayi3 < sayi4)    # / True
print(sayi3 <= sayi4)   # / True
print(sayi3 != sayi4)   # / True

print(dir(sayi1))

# integer parametrelere ait metodlar : 

# 1 - .as_integer_ratio () metodu bir ondalık sayının tam sayı olarak ifade edilmesi için kullanılan fraksiyonel bir yaklaşımı temsil eden Fraction tipinde bir nesne döndürür.

x = 0.125
print(x.as_integer_ratio())
# / (1, 8)

# 2 - .bit_length () metodu bir tam sayının binary (ikili) gösteriminde kaç bit kullandığını döndürür. Bu, tam sayının sıfırdan farklı en sol bitinden başlayarak kaç bit kullanıldığını verir.

x = 10
print(x.bit_length())
# / 4 (10 u 2ye bölüp bölüm olan 5i tekrar 2ye bölüp 1010 şeklinde sayı bulmaya binary (ikili) sayı denir.)


# 3 - .conjugate () metodubir karmaşık sayının eşleniğini (conjugate) döndürür.

x = 3+4j
print(x.conjugate())
# / 3-4j


# 4 - .from_bytes () metodu int.from_bytes(bytes, byteorder, *, signed=False) metodu, verilen bayt dizisi (bytes) içeriğine dayalı olarak bir tam sayı (int) döndürür.

# bytes: dönüştürülecek bayt dizisi.
# byteorder: bayt dizisinin düzenini belirten bir parametredir. Bu parametre "big" veya "little" olabilir ve varsayılanı "big" dir.
# signed: işaretli mi yoksa işaretsiz mi olacağını belirleyen bir parametredir. Bu parametre varsayılan olarak Falsedur.

print(int.from_bytes(b'\x00\x12\x34', byteorder='big'))
print(int.from_bytes(b'\x00\x12\x34', byteorder='little'))
print(int.from_bytes(b'\xfc\x00', byteorder='big', signed=True))
# 4660
# 3412480
# -1024



# 5 - .to_bytes () metodutam sayıları baytlara dönüştürmek için kullanılır. Bu yöntem, herhangi bir tam sayıyı özel bir bayt sıralaması (endianness) kullanarak byte dizisine dönüştürür. Ayrıca, dönüştürülen bayt dizisi, verilen byte uzunluğunu geçmediği sürece istenen boyutu da ayarlayabilir.

# to_bytes() metodu, şu parametreleri alır:

# length (zorunlu): Bayt dizisi uzunluğunu belirten bir tamsayıdır.
# byteorder (opsiyonel): Bayt sıralamasını belirten bir string değerdir. "big" veya "little" olarak belirlenebilir. Varsayılan olarak, byte order big-endian olarak belirlenmiştir.

num = 65535
num_bytes = num.to_bytes(2, byteorder='big')
print(num_bytes)

# / b'\xff\xff'

# float parametrelere ait metodlar : 

# 1 - .as_integer_ratio () metodu
# 2 - .conjugate () metodu
# 3 - .fromhex () metodu
# 4 - .hex () metodu
# 5 - .is_integer () metodu
