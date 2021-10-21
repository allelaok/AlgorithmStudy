// 변수 ptr 을 이용해 변수 b에 100을 저장해주세요.
// 조건 : b = 100을 사용하면 안됩니다.

#include <stdio.h>

int main(void) {
  
  int a;
  printf("a : %ld\n", (long)&a);
  char b;
  printf("b : %ld\n", (long)&b);
  char c;
  printf("c : %ld\n", (long)&c);
  char d;
  printf("d : %ld\n", (long)&d);
  int e;
  printf("e : %ld\n", (long)&e);

  int* ptr = &e;
  printf("ptr : %ld\n", (long)(ptr));

  // =============== 수정가능지역 시작 ===============
  printf("ptr + 7 : %ld\n", (long)((char*)ptr + 7));
  *((char *)ptr + 7) = 100;
   

  // =============== 수정가능지역 끝 ================

  printf("=================변수 b의 값==================\n");
  
  printf("b : %d\n", b);

  // 출력 : 100
  

  return 0;
}