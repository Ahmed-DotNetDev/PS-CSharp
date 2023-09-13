public class Solution {
    public int[] PlusOne(int[] digits) {
       //9
var asn = new List<int>();
int carry = 1;
int size = digits.Length - 1;
for (int i = size; i >= 0; i--)
{
	int a = digits[i] + carry;//10
	carry = a / 10; //10 =1
	a %= 10;  //0
	asn.Add(a);
}
if (carry > 0)
{
	asn.Add(carry);
}
asn.Reverse();
return asn.ToArray();
}}