# Simple reading of available ports using WinForms and C#

### Step 1: Install a NuGet package: **System.IO.Ports**
![image](https://github.com/user-attachments/assets/918730fc-41ff-4708-8de4-bb81b9176d74)

### Step 2: Get ports using **SerialPort.GetPortNames** and display the items in the listbox.
```
 public void GetPorts()
 {
     string[] ports = SerialPort.GetPortNames();

     if (ports != null && ports.Length > 0)
     {
         lblStatus.Text = "Ports found!";
         portList.Items.Clear();

         foreach (string port in ports)
         {
             portList.Items.Add(port);
         }
     }
     else
     {
         lblStatus.Text = "No ports found!";
     }
 }
```
##Output
![image](https://github.com/user-attachments/assets/cead95d9-4b7e-497b-8739-10fdc563c86b)

**Tip: Read all the comments and try to debug line by line in order to study it better.**

### If you encounter an error, please leave a comment of your error and I will try to answer as soon as possible. 
### Happy learning!
