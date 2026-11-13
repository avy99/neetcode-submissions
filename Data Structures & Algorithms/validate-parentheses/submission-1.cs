public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();
        for(int i =0; i<s.Length; i++){
            if(s[i] == '(' || s[i]== '{' || s[i]== '['){
                stack.Push(s[i]);
            }
            else{
                char c;
                if(stack.Count>0) c = stack.Pop();
                else return false;
                if(s[i] == ')' || s[i]== '}' || s[i]== ']'){                    
                    switch(c){
                        case '(' : if(!(s[i] == ')')) return false; break;
                        case '{' : if(!(s[i] == '}')) return false; break;
                        case '[' : if(!(s[i] == ']')) return false; break;
                        default: return false; break;
                    }
                }
            } 
        }

        return stack.Count == 0;
    }
}
