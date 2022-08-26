# CSE230-Week1
Example code to follow along with the Week 1 Lecture Notes


Windows Forms and the User Interface

	- The Position of the Form
		○ Determined by 2 properties
			§ startPosition - where in the screen the form will be when it first start
			§ topMost
			§ If set to manual its location is set in Location Property
		Manual	Set by form's Location Property
		Center Screen	Starts in center of Screen
		WindowsDefaultLocation	Default position and set by the size property
		WindowsDefaultBounds	Default position and default size
		CenterParent	Center of parent container
	- Lets Take  Look at the Code

Example in Code:

	1. Follow along in the Start a New Project Steps
		a. Make sure to Name The Project and Soloution
	2. Change the startPosition to each setting and run it and test it
		a. Remember these are properties of the Form, so in our property window we should be able to find them
		b. 
	3. Click on another application and your goes in back
	4. Change topMost property to true and try again

Nonrectangular Windows Forms

	Creating windows forms are pretty easy, but a square is pretty boring. Lets take a look at how we can change to a different shape. In this example, we are going to take our project and add a button to change the form shape to a an Oval.

	Example in Code:
	1. With our project sill open, or you can create a new one
	2. Add A button
		a. Make sure to give your button a meaningful name (THIS WILL MATTER IN LABS)
		b. Update the text
		c. 
	3. In the code change the background color  and border style should be none
		a. 
	4. In Our Button OnClick Event (FOR C# you need to double click the button on the form), add the following code
		System.Drawing.Drawing2D.GraphicsPath mypath = new System.Drawing.Drawing2D.GraphicsPath(); 
		mypath.AddEllipse(0, 0, this.Width, this.Height); 
		Region myRegion = new Region(mypath); 
		this.Region = myRegion
	5. Run the Code and See What Happens
	6. Add another Button - this will change the border style on click
		a. 
	7. Add another button - Change Form Size
		a. 
		
	8. Add another button - Change Opacity
		a. 
	9. Run the Code and See how it all works
	10. Feel free to mess with the opacity and size to find out what all you can do


Now circles are cool and everything, but we can also generate polygons. Below is the code. Update the "Click Me" button and see what happens
	- System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath(); 
myPath.AddPolygon(new Point[] { new Point(0, 0), new Point(0, this.Height), new Point(this.Width, 0) }); 
Region myRegion = new Region(myPath); this.Region = myRegion;

Adding Controls at Runtime
	1. Add a new Project to our Solution
		○ Right click in solution explorer and choose new Project
	2. Once you have a new project, add a Button to the form.
	3. In the OnClick event add this code
	            Button btnGenOnFly = new Button();
	            btnGenOnFly.Location = new Point(20, 20);
	            btnGenOnFly.Text = "Test Button";
	            this.Controls.Add(btnGenOnFly);
	4. Run your code and see what happens
	
	
	- The benefit of this, is you can start adding all of your component via Code in the Form constructor if you choose. In labs throughout the semester, that will be a requirement so make sure you pay attention to the details of each assignment 
	


FlowLayout Panel Control
	- Subclass of Panel Control  Dynamically repositions the controls it hosts based on its size in design and runtime 
	- FlowDirection property 
		○ LeftToRight 
		○ RightToLeft
		○ TopDown 
		○ BottomUp 
	- WrapContents 
		○ True/false 
		○ If true it auto wraps to next column 
		○ If false you have to manually create breaks 
		○ Can have scrollbars

	Example in Code:
	
	1. Add new Project
	2. Add a flowLayoutPanel
	3. Dock it on the form (this is a property)
		a. You can choose, for this example I am going to use the Fill option
	4. Add 4-5 buttons
	5. Add this code to the Form1 Constructor
		a. flowLayoutPanel1.SetFlowBreak(button1, true); 
		b. Make sure to have this line for a  few of your buttons
	6. Double click each button to generate the onClick function
	7. Create a private method, and copy this code in
		            Button btnClicked = sender as Button;
		            if (flowLayoutPanel1.GetFlowBreak(btnClicked))
		            {
		                MessageBox.Show("Flowbreak is set");
		            }
		            else
		            {
		                MessageBox.Show("Flowbreak is NOT set");
		            }
		a. 
	8. Add your function call to each of your button click functions
	9. Run your code and see what happens


Table Layout Panel Control

Example in Code:

	1. Add another project to our week 1 Solution
	2. Add a tableLayoutPanel control
	3. Add a button to each cell
	4. Dock the panel in the form
	5. Double Click to create an onClick event handler for one of your buttons
		a. Add the following code to generate a new button
		b. Notice the last line allows us to specify what cell we want
			i. Columns Start at 1
			ii. Cells start at 0
		c. Button abutton = new Button(); 
abutton.Text = "New Button 2"; 
abutton.Width = 150; 
//To Specify which Cell 
tableLayoutPanel1.Controls.Add(abutton, 2,1);
	6. Run Your Code to see what happens


Tab Control
	- Most important part is tabpages
		○ Tabpages are containers hosted inside the tabcontrol controls
		○ Can change the property to allow them to be scrollable
		○ Each has a text property that displays on its tab
	- Multiline determine if it has more than one row of tabs

Example in Code:
	1. Add another project to our Week 1 Solution
	2. Add a tab control to the form
	3. Add controls to each page of the tab control
	4. Click on the tab to switch between pages
	5. Click the ellipsis in the tabpages property to add or arrange the tabpages
		a. 
	6. Take some time to play around and try adding different controls to each tab


SplitContainer Control
	- Usually docked and can split the container intowo 2 panels
	- Can set the orientation to
		○ Vertical
		○ Horizontal
	- isSplitterFixed
		○ Makes splitter unchageable during runtime
	- Pnael1Collapsed, panel2Collapsed - make a panel invisible


Example in Code:

	1. Add Another Project to our Week 1 Solution
	2. Add a splitContainer control to the form
		a. Name it parentContainer
	3. Dock it
	4. Change orientation property to horizontal
	5. Add a button  to the top panel
	6. Add another splitContainer control to the bottom panel
		a. Name this: listContainer
		b. Dock this to the parent
	7. Add a listbox to each panel
	8. Run your code and test it out
	9. 

	
	
	
		
	
	
	
![image](https://user-images.githubusercontent.com/7133872/186944343-802ace64-ccff-49cd-acbb-32194f6d922b.png)
