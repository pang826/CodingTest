#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int price) {
    int answer;
    
    if(price >= 500000)
    {
        answer = price - (price * 0.2f);
    }
    else if(price >= 300000)
    {
        answer = price - (price * 0.1f);
    }
    else if(price >= 100000)
    {
        answer = price - (price * 0.05f);
    }
    else
    {
        answer = price;
    }
    
    
    return answer;
}