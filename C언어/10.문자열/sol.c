// 문제 : 문장에서 특정 문장의 위치를 반환하는 함수를 만들어주세요.(get_index_of_str)

int get_str_len(char* str){
  int i; 
  for (i = 0; str[i] != '\0'; i++);
  return i;
}

int get_index_of_str(char* arr, char* arr2){

  int index;

  for (int i = 0; arr[i] != '\0'; i++){
    if (arr[i] == arr2[0]){
      index = i;
      break;
    }
  }

  int flag = 0;

  for (int i = 0; i < arr2[i] != '\0'; i++){
    if (arr[index + i] == arr2[i]){
      flag = 1;
    }
    else {
      flag = 0;
    }
  }

  if (flag){
    return index;
  }

  return -1;
}

#include <stdio.h>

int main(void) {
  int index;
  
  index = get_index_of_str("abc", "b");
  printf("index : %d\n", index);
  // 출력 => index : 1

  index = get_index_of_str("test", "es");
  printf("index : %d\n", index);
  // 출력 => index : 1

  index = get_index_of_str("abcd", "bd");
  printf("index : %d\n", index);
  // 출력 => index : -1

  return 0;
}