﻿namespace TextRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartGame.Start();
        }
    }
}


//구현하지 못한 것들(필수 기능 구현 중에서) 
//(도전 기능 구현 전체..)
//아이템 장착에 따라 상태창 정보에 수치를 반영하는 기능
//장착 관리에서, 이미 장착중이라면 장착을 해제하는 기능
//중복 장착을 허용하는 기능(따로 구현하지 않아도 되나?)
//보유 금액에 따라 아이템 구매 가능 여부를 판단하는 기능
//보유 금액이 구매한 값에 따라 차감된 걸 반영하는 기능

//발견한 에러
//isPurchased는 개별 아이템의 구매 상태가 아니라 전체 아이템의 구매 상태를 나타내고 있음, 
//따라서 아이템을 구매할 때마다 isPurchased를 true로 바꾸면 안됨
//한번이라도 구매하면, 다른 아이템을 구매할 때도 이미 구매한 아이템이라고 나옴

//3번째 아이템을 구매해도, 1번째 아이템을 구매한 것으로 나옴
//아마 MyItem에 추가하는 과정에서 오류가 있는 것 같음




//에러 수정
//itemPrice를 구매완료라는 문자열로 바꿀 수 없음
//매개변수를 bool값으로 통제해주기
//EquipItem()에서 ItemList()를 호출하면 안되고, 그냥 콘솔에 출력만 해주면 됨
