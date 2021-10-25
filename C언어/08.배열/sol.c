// 문제 : 고객에게 숫자를 10개 입력받아서 배열에 넣기

#include <stdio.h>

int main(void) {

  int arr[10];

  for (int i = 0; i < 10; i++){
    scanf("%d", &arr[i]);
  }

  //v1 
  // 배열문법 사용해서 10개 받아 출력하기.
  for (int i = 0; i < 10; i++){
    printf("%d ", arr[i]);
  }

  printf("\n");
  //v2 
  // 배열문법 사용X 10개 받아 출력하기.
  // 배열변수의 의미에 대해 알아야 함.
  for (int i = 0; i < 10; i++){
    scanf("%d", arr + i);
  }

  for (int i = 0; i < 10; i++){
    printf("%d ", *(arr + i));
  }

  return 0;
}