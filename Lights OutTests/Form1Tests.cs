using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lights_Out;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lights_Out.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        // Test to see if the checkStatus can find that all lights are off
        [TestMethod()]
        public void CheckStatus_FindEnd()
        {
            // Generate new game
            var testForm = new Form1();

            // Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Expected the status to find that all lights are off
            bool expected = true;
            // Get actual result
            bool actual = testForm.checkStatus();
            // Assert they are the same
            Assert.AreEqual(expected, actual);
        }

        // Test to see if the checkStatus can find that all lights are not off
        [TestMethod()]
        public void CheckStatus_FindNotEnd()
        {
            // Generate new game
            var testForm = new Form1();

            // Turn one light on
            testForm.lightsMatrix[1, 1] = true;

            // Expected the status to find that some lights are on
            bool expected = false;
            // Get actual result
            bool actual = testForm.checkStatus();
            // Assert they are the same
            Assert.AreEqual(expected, actual);

        }

        // Test to see if random start makes sure there's a least one light on
        [TestMethod()]
        public void RandomStart_OneLightOn()
        {
            // Generate new game
            var testForm = new Form1();

            // Call random Start function
            testForm.randomStart();

            // Expected the status to find that some lights are on
            bool expected = true;
            // Assume actual is false unless found light on
            bool actual = false;

            // Loop through all bools in bool array
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    // Check if light is on
                    if (testForm.lightsMatrix[i, j] == true)
                    {
                        // If any light is on then random start worked
                        actual = true;
                    }
                }
            }

            // Assert expected and actual are same
            Assert.AreEqual(expected, actual);
        }

        // Test to see if clicked middle button inverts correct lights
        [TestMethod()]
        public void LightClick_NormalInvert()
        {
            // Generate new game
            var testForm = new Form1();

            //Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Click middle button
            testForm.invertHandler(testForm.lights[2, 2], 2, 2);

            Assert.AreEqual(true, testForm.lightsMatrix[2, 2]);
            Assert.AreEqual(true, testForm.lightsMatrix[2, 3]);
            Assert.AreEqual(true, testForm.lightsMatrix[2, 1]);
            Assert.AreEqual(true, testForm.lightsMatrix[1, 2]);
            Assert.AreEqual(true, testForm.lightsMatrix[3, 2]);
        }

        // Test to see if clicking top left corner button inverts correct lights
        [TestMethod()]
        public void LightClick_TopLeftInvert()
        {
            // Generate new game
            var testForm = new Form1();

            //Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Click top left corner button
            testForm.invertHandler(testForm.lights[0, 0], 0, 0);

            Assert.AreEqual(true, testForm.lightsMatrix[0, 0]);
            Assert.AreEqual(true, testForm.lightsMatrix[0, 1]);
            Assert.AreEqual(true, testForm.lightsMatrix[1, 0]);
        }

        // Test to see if clicking top right corner button inverts correct lights
        [TestMethod()]
        public void LightClick_TopRightInvert()
        {
            // Generate new game
            var testForm = new Form1();

            //Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Click top right corner button
            testForm.invertHandler(testForm.lights[0, 4], 0, 4);

            Assert.AreEqual(true, testForm.lightsMatrix[0, 4]);
            Assert.AreEqual(true, testForm.lightsMatrix[0, 3]);
            Assert.AreEqual(true, testForm.lightsMatrix[1, 4]);
        }

        // Test to see if clicking top middle button inverts correct lights
        [TestMethod()]
        public void LightClick_TopMiddleInvert()
        {
            // Generate new game
            var testForm = new Form1();

            //Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Click top middle button
            testForm.invertHandler(testForm.lights[0, 2], 0, 2);

            Assert.AreEqual(true, testForm.lightsMatrix[0, 2]);
            Assert.AreEqual(true, testForm.lightsMatrix[0, 3]);
            Assert.AreEqual(true, testForm.lightsMatrix[0, 1]);
            Assert.AreEqual(true, testForm.lightsMatrix[1, 2]);
        }

        // Test to see if clicking left middle button inverts correct lights
        [TestMethod()]
        public void LightClick_LeftMiddleInvert()
        {
            // Generate new game
            var testForm = new Form1();

            //Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Click left middle button
            testForm.invertHandler(testForm.lights[2, 0], 2, 0);

            Assert.AreEqual(true, testForm.lightsMatrix[2, 0]);
            Assert.AreEqual(true, testForm.lightsMatrix[1, 0]);
            Assert.AreEqual(true, testForm.lightsMatrix[3, 0]);
            Assert.AreEqual(true, testForm.lightsMatrix[2, 1]);
        }

        // Test to see if clicking right middle button inverts correct lights
        [TestMethod()]
        public void LightClick_RightMiddleInvert()
        {
            // Generate new game
            var testForm = new Form1();

            //Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Click right middle button
            testForm.invertHandler(testForm.lights[2, 4], 2, 4);

            Assert.AreEqual(true, testForm.lightsMatrix[2, 4]);
            Assert.AreEqual(true, testForm.lightsMatrix[1, 4]);
            Assert.AreEqual(true, testForm.lightsMatrix[3, 4]);
            Assert.AreEqual(true, testForm.lightsMatrix[2, 3]);
        }

        // Test to see if clicking bottom middle button inverts correct lights
        [TestMethod()]
        public void LightClick_BottomMiddleInvert()
        {
            // Generate new game
            var testForm = new Form1();

            //Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Click bottom middle button
            testForm.invertHandler(testForm.lights[4, 2], 4, 2);

            Assert.AreEqual(true, testForm.lightsMatrix[4, 2]);
            Assert.AreEqual(true, testForm.lightsMatrix[4, 1]);
            Assert.AreEqual(true, testForm.lightsMatrix[4, 3]);
            Assert.AreEqual(true, testForm.lightsMatrix[3, 2]);
        }

        // Test to see if clicking bottom left button inverts correct lights
        [TestMethod()]
        public void LightClick_BottomLeftInvert()
        {
            // Generate new game
            var testForm = new Form1();

            //Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Click bottom left button
            testForm.invertHandler(testForm.lights[4, 0], 4, 0);

            Assert.AreEqual(true, testForm.lightsMatrix[4, 0]);
            Assert.AreEqual(true, testForm.lightsMatrix[4, 1]);
            Assert.AreEqual(true, testForm.lightsMatrix[3, 0]);
        }

        // Test to see if clicking bottom right button inverts correct lights
        [TestMethod()]
        public void LightClick_BottomRightInvert()
        {
            // Generate new game
            var testForm = new Form1();

            //Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Click bottom right button
            testForm.invertHandler(testForm.lights[4, 4], 4, 4);

            Assert.AreEqual(true, testForm.lightsMatrix[4, 4]);
            Assert.AreEqual(true, testForm.lightsMatrix[4, 3]);
            Assert.AreEqual(true, testForm.lightsMatrix[3, 4]);
        }

        // Test lightClick of last light
        [TestMethod()]
        public void LightClick_LastLight()
        {
            // Generate new game
            var testForm = new Form1();

            //Set all lights to be off
            for (int i = 0; i < testForm.lightsMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < testForm.lightsMatrix.GetLength(0); j++)
                {
                    testForm.lightsMatrix[i, j] = false;
                }
            }

            // Set middle diamond to be on ready for final click
            testForm.lightsMatrix[2, 2] = true;
            testForm.lightsMatrix[2, 1] = true;
            testForm.lightsMatrix[2, 3] = true;
            testForm.lightsMatrix[1, 2] = true;
            testForm.lightsMatrix[3, 2] = true;

            // Click middle button
            testForm.invertHandler(testForm.lights[2, 2], 2, 2);

            // Expected the status to find that all lights are off
            bool expected = true;
            // Get actual result
            bool actual = testForm.checkStatus();
            // Assert they are the same
            Assert.AreEqual(expected, actual);

        }

        // Test invertButton changes colour of button
        [TestMethod()]
        public void invertButton_changeColour()
        {
            // Generate new game
            var testForm = new Form1();

            // Set light to black
            testForm.lights[0, 0].BackColor = Color.Black;

            // Invert set light
            testForm.invertButton(testForm.lights[0, 0], 0, 0);

            bool expected = true;
            bool actual = false;

            // If light is no longer black then it worked
            if (testForm.lights[0, 0].BackColor != Color.Black)
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);
        }

        // Test invertButton handles invert bool array values
        [TestMethod()]
        public void invertButton_changeStatus()
        {
            // Generate new game
            var testForm = new Form1();

            // Set light to false
            testForm.lightsMatrix[0, 0] = false;

            // Invert set light
            testForm.invertButton(testForm.lights[0, 0], 0, 0);

            // Expect light value to be true
            bool expected = true;
            Assert.AreEqual(expected, testForm.lightsMatrix[0, 0]);
        }
    }
}