/**
 * Hoisting
 */

console.log('Hello');
console.log('world');
console.log('------');

console.log(name);

/**
 * what is hoisting?
 * 모든 변수 선언문이 코드의 최상단으로 이동되는 것처럼 느껴지는 현상을 이야기한다.
 * ai - var는 호이스팅 시 선언과 초기화(undefined)가 동시에 진행되므로 에러가 발생하지 않는다.
 */
var name = 'code Factory';
console.log(name);

/**
 * let과 const도 hoisting이 되는가?
 * ai - 호이스팅은 된다.
 * ai - 하지만 var와 달리 초기화(undefined 할당)가 되지 않은 상태로 호이스팅된다.
 * ai - 선언문 도달 전까지 변수에 접근할 수 없는 구간을 TDZ(Temporal Dead Zone)라고 한다.
 */

console.log(yujin);
// let yujin = '안유진';

/**
 * 선언과 초기화의 차이
 * 1. 선언(Declaration): "이런 변수가 있다"고 엔진에 등록하는 단계.
 * 2. 초기화(Initialization): 메모리 공간을 확보하고 undefined로 값을 채우는 단계.
 *
 * - var: 호이스팅 시 선언과 초기화가 동시에 일어남 -> undefined 출력
 * - let/const: 호이스팅 시 선언만 일어남 -> 초기화 전이라 접근 불가(TDZ)
 */
