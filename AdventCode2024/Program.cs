// INPUT READING: 
// END INPUT

/*
MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX
*/

//x [] .. x
//m [] .. m
//a [] .. a
//s [] .. s


// Part 1

int CalcXmas(string l, int x = 0, int m = 0, int a = 0, int s = 0)
{
    if (l.Length > 0)
    {

    }


    return l switch
    {
    [var h, .. var t] when t == "X" => CalcXmas(t, x + 1, m, a, s),
    [var h, .. var t] when t == "M" => CalcXmas(t, x, m + 1, a, s),
    [var h, .. var t] when t == "A" => CalcXmas(t, x, m, a + 1, s),
    [var h, .. var t] when t == "S" => CalcXmas(t, x, m, a, s + 1),

    };

}