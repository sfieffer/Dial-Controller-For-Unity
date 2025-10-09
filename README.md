# Dial-Controller-For-Unity
<b> Instructions on how we built a dial controller to use in Unity to track real-time FMS/Discomfort Score. Has many other practical use cases as well. <br>
Created for CyberScore project at VRAC at Iowa State University. <br>
Project members: Stephen J. Fieffer, Alexa Hatcher, Ghazal ShahAbadi, Jacob Becker, Jake Shaheen, Michael C. Dorneich, Stephen B. Gilbert </b><br>

https://github.com/user-attachments/assets/531f2698-b040-4594-8165-f1b4c811e7ca
<div style="text-align: center;">

![IMG_7600_small](https://github.com/user-attachments/assets/22fa0731-2201-4b28-871f-dacfbc05186e)
</div>

## Hardware
Rotary Encoder with Push Switch - https://www.ricmotech.com/rotary-encoder-with-push-switch-diy

Leo Bodnar 32-Input Button Box Interface Board - https://www.ricmotech.com/leo-bodnar-32-input-button-box-interface-board

Jumper wire connectors – A male to female wire would be most efficient. However, the male end may not be long enough to be inserted into the buttonboard. Because of this, we used a basic wire inserted into the button board and a female to female jumper wire.

We purchased both items from the RicmoTech website linked above (not affiliated). There is an option for a rotary encoder without a push switch for $1 cheaper that you could purchase – we did not use the push switch in our build.

## Software
The file “DialFunction.cs” contains the Unity script that gives the dial functionality within any Unity projects.<br>
The "Slider" folder contains the slider prefab, associated images, and script to use the slider with the faces. This can be easily modified to use other images. Attach the Slider prefab to a Canvas element in the Unity scene.

## How To
Connect the dial to the button board through male-to-female connector wires as seen in the diagram below. Connect the outer two pins to button board inputs, and the middle pin to ground. <br>

<img width="731" height="490" alt="image" src="https://github.com/user-attachments/assets/c223d3d1-ec0a-494f-96ff-60284974e525" />
<br>
<br>
To identify which buttons are in use, follow these steps (It should be the two numbers that you plugged the wires into on the board):
1. Press Windows + R and tyle joy.cpl
2. Select the button box interface and click properties
3. Identify which two buttons light up red when you spin the dial.
<br>
<img width="730" height="427" alt="image" src="https://github.com/user-attachments/assets/f62aada0-d9ac-47b7-bfcb-3e75c0850e2b" />
<br>
<br>
Within the Unity script, you may need to edit the buttonA and buttonB parameters. These should be the values identified in the joy.cpl window minus 1. If 4 & 5 light up red, enter 3 & 4. If the dial is spinning in the opposite direction than you’d like, simply swap the numbers assigned to buttonA and button.

## 3D Printed Case
To hold the button board and dial together, we designed, and 3D printed a case. The files can be found in the “3D Printed Case” folder. To assemble this case, place the rotary encoder within the bounds of the rotaryholder print after the wires are attached and slide it into the shell part. This is easiest upside down. Finally, place the button board inside the outerbox and slide the bottom panel into the rails to secure the contents within the shell. <br>
Feel free to create a better housing design and please reach out to me with it!

![IMG_7601_small](https://github.com/user-attachments/assets/2af991af-f3ad-40f5-9e42-30b1ced30b87) <br>
![IMG_7602_small](https://github.com/user-attachments/assets/a7d0c6c0-74ba-4bc3-9ba2-57301f0278a5) 
![IMG_7603_small](https://github.com/user-attachments/assets/b82e7542-3d22-4d73-a3f0-1a21742b1ff6)
