service MyThriftService {
	double GetSum(1: double num1, 2: double num2),
	string GetHelloMessage(1: string name),
    oneway void OpenWindow(1: string title),
}
