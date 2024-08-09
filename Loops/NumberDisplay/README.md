### Number Display

**Objective**: Write code to display numbers from 1 to 100 in a ListBox when a button is clicked.

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
   private void btnDisplay_Click(object sender, EventArgs e)
   {
       lstDisplay.Items.Clear(); // Clear the ListBox before adding new items
       for (int i = 1; i <= 100; i++)
       {
           listBox1.Items.Add(i);
       }
   }
   ```

   - The `lstDisplay.Items.Clear()` method ensures that the ListBox is cleared each time the button is clicked, preventing duplicate entries.

4. **Test the Application**:
   - Run the application by pressing **F5**.
   - Click the "Show Numbers" button on the form.
   - Verify that the ListBox displays the numbers 1 through 100.

5. **Save Your Work**:
   - After verifying that your code works as expected, save the project by selecting **File > Save All**.

#### Additional Tips:
- If you'd like to challenge yourself further, try modifying the loop to display only even numbers or numbers in reverse order.
