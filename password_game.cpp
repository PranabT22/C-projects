#include <iostream>
#include <string>
#include <cctype>
#include <vector>

int main() {
    std::cout << "+---------------+\n";
    std::cout << "The Password Game\n";
    std::cout << "+---------------+\n";

    std::string password;
    std::cout << "Please choose a password: ";
    std::cin >> password;

    // Check for negative sign
    if (password[0] == '-') {
        std::cout << "The number needs to be a positive number\n";
        return 0;
    }

    // Check that all characters are digits
    for (char c : password) {
        if (!std::isdigit(c)) {
            std::cout << "The password must contain only numbers\n";
            return 0;
        }
    }

    // Check length
    if (password.length() < 7) {
        std::cout << "The password must be at least 7 digits long\n";
        return 0;
    }

    // Month check
    std::vector<std::string> months = {
        "january", "february", "march", "april", "may", "june",
        "july", "august", "september", "october", "november", "december"
    };

    bool containsMonth = false;
    for (const auto& month : months) {
        if (password.find(month) != std::string::npos) {
            containsMonth = true;
            break;
        }
    }

    if (!containsMonth) {
        std::cout << "Input does NOT contain any English months\n";
        return 0;
    }

    std::cout << "Your password is: " << password << "\n";
    return 0;
}
