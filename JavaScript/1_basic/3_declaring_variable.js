/*
변수 선언하기

1) var - 더 이상 사용하지 않음.
2) let
3) const
*/

var name = 'code factory';
console.log(name);

var age = 32;
console.log(age);

let ive = '아이브';
console.log(ive);
/**
 * let과 var로 선언하면
 * 값을 나중에 변경할 수 있다.
 */
ive = '안유진';
console.log(ive);

const newjeans = '뉴진즈';
console.log(newjeans);
//newjeans = 'code factory';
//console.log(newjeans);
/**
 * const 선언시
 * 값을 나중에 변경할 수 없다.
 */

/**
 * 선언과 할당
 * 전제조건: 모든 선언은 메모리를 값으로 지불한다.
 * 1.선언 -> 변수를 할당한다.
 * 2.할당
 */

var name = 'code factory';
console.log(name);

let girlfreind;
console.log(girlfreind); //result is undefined

// const girlfreind2; //선언을 초기화해야 합니다.
