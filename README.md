# HW2


#Itch.io Link
https://gamedev-hw.itch.io/hw2


# Explanation for the Camera Sizing Problem
The screen-rotation sizing problem occurs when the game switches between landscape and portrait orientations or when the game window is resized. Because the screen's width, height, and aspect ratio change, the minimap may appear too large or too small relative to the game screen. This happens because fixed UI dimensions do not automatically adapt to different screen sizes, while the camera's orthographic size may also change based on the screen resolution. As a result, the minimap can take up too much space or become difficult to see, creating an inconsistent user experience across different devices and screen orientations.
