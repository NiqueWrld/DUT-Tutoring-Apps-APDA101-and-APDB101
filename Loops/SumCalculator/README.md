### Sum Calculator

**Objective**: Write code to when the button is clicked, use a for loop to calculate the sum of all numbers in that range and display the result in a Label.

#### Instructions:

1. **Download and Open the Project**:
   - Download the provided project files from the repository.
   - Unzip the folder (if necessary).
   - Open the project in Visual Studio by double-clicking the `.sln` file.

2. **Locate the Form**:
   - In Solution Explorer, find and open the `Form1.cs` file. This file contains the GUI with a Button and a ListBox that have already been created for you.

3. **Implement the Button Click Event**:
   - Double-click the Button on the form in the Designer to generate the `Click` event handler in the code-behind file (`Form1.cs`).
   - Inside the `Click` event handler, write a for loop that iterates from 1 to 100 and adds each number to the ListBox.

   Here is the code you should add inside the Button's `Click` event handler:

   ```csharp
    private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int startNumber;
            int endNumber;
            bool isStartValid = int.TryParse(textBoxStart.Text, out startNumber);
            bool isEndValid = int.TryParse(textBoxEnd.Text, out endNumber);

            if (isStartValid && isEndValid)
            {
                int sum = 0;
                for (int i = startNumber; i <= endNumber; i++)
                {
                    sum += i;
                }
                labelResult.Text = $"Result: {sum}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
   ```

   - The ` MessageBox.Show("Please enter valid numbers.");` method alerts the user if they entered an invalid number.

4. **Test the Application**:
   - Run the application by pressing **F5**.
   - Click the "Show Numbers" button on the form.
   - Verify that the app calculates the sum of all numbers in that range

5. **Save Your Work**:
   - After verifying that your code works as expected, save the project by selecting **File > Save All**.

#### Additional Tips:
- If you'd like to challenge yourself further, try modifying the app to display all types of data sizes
