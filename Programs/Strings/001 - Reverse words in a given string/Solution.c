#include <stdio.h>
#include <string.h>

void reverse(char* begin, char* end)
{
    char temp;
    while (begin < end) {
        temp = *begin;
        *begin++ = *end;
        *end-- = temp;
    }
}

void reverseWords(char* s)
{
    char* word_begin = NULL;
    char* temp =  s;
    
    while ( *temp )
    {
        if ( ( word_begin == NULL ) &&
             ( *temp != ' ' ) )
             word_begin = temp;
             
        if ( word_begin &&
             ((*(temp + 1) == ' ' ) ||
              (*(temp + 1) == '\0' )))
        {
            reverse(word_begin, temp);
            word_begin = NULL;
        }
        temp++;
    }
    reverse(s, temp - 1);
}

int main()
{
    char s[] = "i like this program very much";
    char* temp = s;
    reverseWords(s);
    printf("%s", s);
    return 0;
}
