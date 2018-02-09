using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//** Author: Suzanne Townsend
//	 Date: 28/07/2017
//	 Purpose: Display understanding of linkedLists and it's functions.


namespace AT1._1_Diploma
{
	public partial class LinkedLists : Form
	{
		public LinkedLists()
		{
			InitializeComponent();
		}

		//Create linked list
		LinkedList<string> myCarCollection = new LinkedList<string>();
		string erMsg = "Error";

		//Method developed to show the linkedLists contents in the list box.
		private void ShowLinkedList()
		{
			// clear Items
			listBoxOutput.Items.Clear();
			textBoxCarName.Clear();
			textBoxNodePosition.Clear();
			//Set Num of Nodes text box to Number Of nodes using NumberOfNodes method.
			textBoxNumOfNodes.Text = NumberOfNodes().ToString();
			//loop to display the nodes of the linkedList
			foreach (string car in myCarCollection)
			{
				listBoxOutput.Items.Add(car);
			}
			textBoxCarName.Focus();
		}

		// .Count used to count the the entire number of nodes that occupy the listBox
		private int NumberOfNodes()
		{
			return myCarCollection.Count;
		}

		private void AddLastBtn_Click(object sender, EventArgs e)
		{
			//If string not null or empty, add text from textBoxCarName to the LAST node position in the Linked List
			// else display error message
			if (!string.IsNullOrEmpty(textBoxCarName.Text))
			{
				myCarCollection.AddLast(textBoxCarName.Text);
				// show item in listBox
				ShowLinkedList();
				textBoxCarName.Focus();
			}
			else
				MessageBox.Show("Please enter a car name.", erMsg);
		}

		private void AddBeforeBtn_Click(object sender, EventArgs e)
		{
			//If string not null or empty, Find the node Selected in the ListBox and add the data in the textBoxCarName BEFORE the selected node.
			// else display error message

			// Due to using this method to add before and after my node position box will now be 
			//Read Only and display the nodes Current index postion upon 'click'.
			if (listBoxOutput.SelectedItem != null && !string.IsNullOrEmpty(textBoxCarName.Text))
			{
				LinkedListNode<string> current = myCarCollection.Find(Convert.ToString(listBoxOutput.SelectedItem));
				myCarCollection.AddBefore(current, textBoxCarName.Text);
				ShowLinkedList();
				textBoxCarName.Focus();
			}
			else
				MessageBox.Show("Please enter a car name and select the item you wish it to go before.", erMsg);
		}

		private void AddAfterBtn_Click(object sender, EventArgs e)
		{
			//If string not null or empty, Find the node Selected in the ListBox and add the data in the textBoxCarName AFTER the selected node.
			// else display error message
			if (listBoxOutput.SelectedItem != null && !string.IsNullOrEmpty(textBoxCarName.Text))
			{
				LinkedListNode<string> current = myCarCollection.Find(Convert.ToString(listBoxOutput.SelectedItem));
				myCarCollection.AddAfter(current, textBoxCarName.Text);
				ShowLinkedList();
				textBoxCarName.Focus();
			}
			else
				MessageBox.Show("Please enter a car name and select the item you wish it to go after.", erMsg);
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			#region EXTRA STUFF :) 
			// For the delete button, I decided to use the select item option again. Reasons: it's less code and just as efficient.
			// I have also included in bellow in comments the original delete option, error handled to check the item exists before deleting.

			//bool exist;
			//if (string.IsNullOrEmpty(textBoxCarName.Text))
			//{
			//	MessageBox.Show("please enter a car name");

			//}
			//if (myCarCollection.Contains(textBoxCarName.Text))
			//{
			//	exist = true;
			//	myCarCollection.Remove(textBoxCarName.Text);
			//	ShowLinkedList();
			//}

			//else
			//{
			//	exist = false;
			//	MessageBox.Show("This does not exist");
			//}
			#endregion

			// If selected item not null, display second chance message. 
			// If dialog result equals OK: .Remove at selected item && display curtosy message. 
			// else if cancel return to program. If null, show error message.
			if (listBoxOutput.SelectedItem != null)
			{
				if (MessageBox.Show("Are you sure you want to permanently delete this Item?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					myCarCollection.Remove(Convert.ToString(listBoxOutput.SelectedItem));
					ShowLinkedList();
					textBoxCarName.Focus();
					MessageBox.Show("Your item has been deleted.", "Thank you");
				}
			}
			else
				MessageBox.Show("Please select a car name from the listbox.", erMsg);
		}

		// this button will clear all fields and the linkedList.
		private void ClearBtn_Click(object sender, EventArgs e)
		{
			textBoxCarName.Clear();
			textBoxNodePosition.Clear();
			textBoxNumOfNodes.Clear();
			myCarCollection.Clear();
			ShowLinkedList();
			textBoxCarName.Focus();
		}

		// this button will add nodes to the first postion.
		private void AddFirstBtn_Click(object sender, EventArgs e)
		{
			//If not null or empty, add the data in textBoxCarName to the list into the FIRST index position. Display in listbox
			//else show error message
			if (!string.IsNullOrEmpty(textBoxCarName.Text))
			{
				listBoxOutput.ClearSelected();
				myCarCollection.AddFirst(textBoxCarName.Text);
				ShowLinkedList();
				textBoxCarName.Clear();
				textBoxCarName.Focus();
			}
			else
			{
				MessageBox.Show("Please enter a car name.", erMsg);
			}
		}

		//This button will find the nodes position and display it in a message box.
		private void FindBtn_Click(object sender, EventArgs e)
		{
			//if not null or empty, find textBoxCarName.Text and "incidateNode"
			//else displaty error message.
			if (!string.IsNullOrEmpty(textBoxCarName.Text))
			{
				LinkedListNode<string> finder = myCarCollection.Find(textBoxCarName.Text);
				IndicateNode(finder, "This is the node position");
				textBoxCarName.Focus();
			}
			else
			{
				MessageBox.Show("Please enter a car name.", erMsg);

			}
		}
		// indicate node is a method used to print the node inbetween its previous and next node.
		private void IndicateNode(LinkedListNode<string> finder, string test)
		{

			if (!myCarCollection.Contains(textBoxCarName.Text))
			{
				MessageBox.Show("This node does not exist", erMsg);
				return;
			}

			StringBuilder result = new StringBuilder("(" + finder.Value + ")");
			LinkedListNode<string> nodeP = finder.Previous;

			while (nodeP != null)
			{
				result.Insert(0, nodeP.Value + " ");
				nodeP = nodeP.Previous;
			}

			finder = finder.Next;
			while (finder != null)
			{
				result.Append(" " + finder.Value);
				finder = finder.Next;
			}

			MessageBox.Show("Node : " + Environment.NewLine + result.ToString(), "Found!!");

		}

		//this event is used to display the node postition upon mouse click.
		private void listBoxOutput_Click(object sender, EventArgs e)
		{
			textBoxNodePosition.Text = listBoxOutput.SelectedIndex.ToString();
		}


		// The DRAG OVER region section of commenting is a drag and drop feature for the list box which I was 
		// unable to finish in time for tomorrows deadline.
		// I need to figure out if my current drag and drop feature is changing the node position or just the 
		// listbox index postition or if in the case of this program those two are the same thing.........
		// If they are not the same, my idea is to combine the use of the .addBefore .addAfter 
		// features of the linked list, with the drag and drop event but my logic isn't complete. 
		// I believe that will entail a simple if else statement involving the e.X and e.Y coordinates ie. 
		// if (old e.X && e.Y > new e.X && e.Y) .addAfter ect. 
		// otherwise if it is not required to use the .addAfter & .addBefore functions and I am changing the 
		// linked lists node postion via listbox index then my code works appart from an issue where my node position
		// text box displays -1 on dropping item.

		#region DRAG OVER (needs fine tuning)

		// ( // WITH *** ARE COMMENTS )
		//
		//
		// DRAG DROP STARTS
		//
		// 
		//

		//private void listBoxOutput_DragDrop_1(object sender, DragEventArgs e)
		//{
		//***this code is defining the cordinates (e.X & e.Y) of where the selected listbox item is
		//Point point = listBoxOutput.PointToClient(new Point(e.X, e.Y));
		//***this is to selects the index from point???
		//int index = this.listBoxOutput.IndexFromPoint(point);
		//***this stops you from throwing out of range exeptions.
		//if (index < 0) index = this.listBoxOutput.Items.Count - 1;
		//object data = listBoxOutput.SelectedItem;
		//***list box remove selected item
		//this.listBoxOutput.Items.Remove(data);
		//***list box insert data at index
		//this.listBoxOutput.Items.Insert(index, data);

		//}
		//
		//
		//
		// DRAG DROP ENDS
		//
		//
		//

		//**************************************************************************************************
		
		//
		//
		//
		// MOUSE DOWN STARTS
		//
		//
		//private void listBoxOutput_MouseDown_1(object sender, MouseEventArgs e)
		//{

		//***if null return, activate dragDrop effect on selected item
		//if (this.listBoxOutput.SelectedItem == null) return;
		//this.listBoxOutput.DoDragDrop(this.listBoxOutput.SelectedItem, DragDropEffects.Move);
		//***Activate click method
		//listBoxOutput_Click(sender, e);

		//}

		//
		//
		//
		// MOUSE DOWN ENDS
		//
		//
		//

		//*************************************************************************************************

		//
		//
		//
		// DRAG OVER STARTS
		//
		//
		//
		//private void listBoxOutput_DragOver_1(object sender, DragEventArgs e)
		//{
			//***gets and sets the drag drop effect//
			//e.Effect = DragDropEffects.Move;
		//}

		//
		//
		//
		// DRAG OVER ENDS
		//
		//
		//
		#endregion




	}
}

	
	
	
	

