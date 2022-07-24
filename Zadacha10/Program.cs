// Обход разных структур
// ((4 - 2) * (1 + 3)) / 10

string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6     7   8    9    10   11

void InOrderTraversal(int pos = 1) // описываем метод
{
    if (pos < tree.Length) //делаем проверку
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // делаем проверку если левое поддерево существует и не являетс пучтым String.IsNullOrEmpty 
        Console.WriteLine(tree[pos]);                                                            // выводи позицию
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right); // делаем проверку если правое поддерево существует и не являетс пучтым String.IsNullOrEmpty 
    }
}
InOrderTraversal();