Dictionary<int, int> mp = new Dictionary<int, int>();

foreach (int num in arr)
{
    mp[num] = mp.GetValueOrDefalut(num, 0) + 1;
}

mp[num]++; or mp[num] = 1 will inc/ set value at that key