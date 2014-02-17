struct ElementOfStack;
struct Stack;

typedef int SizeType;
typedef ElementOfStack *Position;
typedef int ValueType;

//Create a new stack.
Stack *createNewStack();
//Return size of stack.
SizeType size(Stack *stack);
//Return value of head in stack.
//If stack is epmty, function outputs "true' in test.
ValueType top(Stack *stack, bool &test);
//Insert new value in head in stack.
void push(Stack *stack, const ValueType value);
//Delete head element from stack.
//If stack is epmty, function outputs "true" in test.
void pop(Stack *stack, bool &test);
//Delete stack.
void deleteStack(Stack *stack);