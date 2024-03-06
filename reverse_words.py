def reverse_words(string):
 
    words = string.split()

    reversed_words = words[::-1]

    reversed_string = ' '.join(reversed_words)

    return reversed_string

input_string1 = "dkşaslk asdl kasşld aisdk"
input_string2 = "Life is so beautiful"

output_string1 = reverse_words(input_string1)
output_string2 = reverse_words(input_string2)

print(output_string1)
print(output_string2)
