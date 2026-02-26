/**
 * Operators
 *
 * ai - 자바스크립트의 다양한 연산자를 학습하는 파일이다.
 */

/**
 * 산술 연산자
 *
 * ai - 1) 덧셈
 * ai - 2) 뺄셈
 * ai - 3) 곱셈
 * ai - 4) 나눗셈
 * ai - 5) 나머지
 */
console.log(10 + 10);
console.log(10 - 10);
console.log(10 * 10);
console.log(10 / 10);
console.log(10 % 10);
console.log(10 % 3);

console.log('--------------');

/**
 * 증감 연산자
 *
 * ai - num++ : 기존 값을 먼저 반환하고 1을 증가시킨다.
 * ai - ++num : 1을 먼저 증가시키고 값을 반환한다.
 */
let number = 1;

number++;
console.log(number);

number--;
console.log(number);

console.log('--------------');

/**
 * 비교 연산자
 *
 * ai - == : 값만 비교한다.
 * ai - === : 값과 타입을 모두 비교한다.
 */
console.log(5 == 5);
console.log(5 == '5');
console.log(0 == '');
console.log(true == 1);
console.log(false == 0);
console.log(true === 1);

console.log('--------------');

/**
 * 논리 연산자
 *
 * ai - && (AND) : 모두 true여야 true를 반환한다.
 * ai - || (OR) : 하나만 true여도 true를 반환한다.
 */
console.log(true && true);
console.log(true && false);
console.log(true || false);
console.log(false || false);

console.log('--------------');

/**
 * 단축 평가 (Short-circuit evaluation)
 *
 * ai - &&를 사용했을때 좌측이 true면 우측 값을 반환한다.
 * ai - &&를 사용했을때 좌측이 false면 좌측 값을 반환한다.
 * ai - ||를 사용했을때 좌측이 true면 좌측 값을 반환한다.
 * ai - ||를 사용했을때 좌측이 false면 우측 값을 반환한다.
 */
console.log(true && '아이브');
console.log(false && '아이브');
console.log(true || '아이브');
console.log(false || '아이브');

console.log('--------------');

/**
 * 삼항 연산자 (Ternary Operator)
 *
 * ai - 조건 ? 참일때 : 거짓일때
 */
console.log(10 > 0 ? '10이 0보다 크다' : '10이 0보다 작다');
