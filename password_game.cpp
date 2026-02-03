#include <iostream>

int main() {
    std::cout << "+---------------+\n";
    std::cout << "The Password Game\n";
    std::cout << "+---------------+\n";

    int x;
    std::cout << "Please choose a password: ";
    std::cin >> x;
    std::cout << "Your password is: " << x << "\n";

    return 0;
}
