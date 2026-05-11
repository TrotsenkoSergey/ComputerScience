namespace TwoPointers;

/*
 Найти максимальную по длине подстроку, такую что каждый символ в ней встречается не более K раз
 */

public class MaxSubstringWithK
{
    /*
    k = 2
                           r
    a  b  a  c  c  c  d  a 
                l
    
    set: { c : 2, d : 1, a : 1 }

    пока r не дошел до конца или не встретил (set = 2))
      set - добавить (если нет), инкрементить, если есть
      max: 5 - вычисляем на каждом сдвиге right указателя (r - l + 1), кладем в переменную то что больше
      r++

    set - дикрементим, если > 1, в противном случае - удаляем
    l++;

    return max


     nums: [a  b  a  c  c  c  d  a], k = 2
          [[a  b  a  c  c] c  d  a]
   output: [a  b  a  c  c]
     
     */

    // Time: O(n^2), Space: O(n)
    public int FindMax(char[] chars, int k)
    {
        Dictionary<char, int> map = new();
        int length = chars.Length;
        int right = 0;
        int max = 0;

        for (int left = 0; left < length; left++)
        {
            while (right < length && (!map.ContainsKey(chars[right]) || map[chars[right]] < 2))
            {
                if (!map.ContainsKey(chars[right]))
                {
                    map[chars[right]] = 0;
                }
                map[chars[right]]++;

                int currentMax = right - left + 1;
                if (currentMax > max)
                    max = currentMax;

                right++;
            }

            if (map.ContainsKey(chars[left]))
            {
                if (map[chars[left]] > 1)
                    map[chars[left]]--;

                map.Remove(chars[left]);
            }
            left++;
        }

        return max;
    }
}
