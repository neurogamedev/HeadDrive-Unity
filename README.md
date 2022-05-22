# HeadDrive-Unity

![GitHub](https://img.shields.io/github/release/neuromodgames/HeadDrive-Unity?style=for-the-badge)
![GitHub](https://img.shields.io/github/license/neuromodgames/HeadDrive-Unity?style=for-the-badge)

 Literally using your head to drive.
 
![HeadDriveGameplay](https://user-images.githubusercontent.com/88777150/169662776-b3aae7a3-52b8-4a8d-90b4-daf5faccb10a.gif)

## What can you do with it?

The idea is to drive without your hands. In this first instance, you can use the tilt of your head to accelerate or deccelerate/reverse as well as drive left and right. The next iteration will include neurofeedack as a mechanic to drive up the speed.

## The shoulders of giants

This quick prototype was possible thanks to the hard work of others. Here's the sources used:

- Thanks to [mmmmmm44](https://github.com/mmmmmm44) for developing the [VTuber Python Unity Tutorial](https://github.com/mmmmmm44/VTuber-Python-Unity) and its subsequent updates. I used part of his code for facial tracking and TCP setup.

- Thanks to [Zukomazi](https://www.youtube.com/c/Zukomazi) for developing the [Free Car Controller](https://www.youtube.com/watch?v=WjT1acvP9pc).

- Thanks to [ALIyerEdon](https://assetstore.unity.com/publishers/23606) for developing the [White City](https://assetstore.unity.com/packages/3d/environments/urban/white-city-76766) asset pack.

- Thanks to Unity Technologies for making the [Unity Editor](https://unity.com/) accessible to everyone.

## How to use

1. Set the development environment up (see below) before opening Unity.
2. Open and run the **HeadDriving.unity** scene in the Scenes folder.
3. Click the START button in the TCP Settings GUI on the top-left.
4. In the Anaconda Prompt, go to the folder _.../HeadDriving/Python/HeadTilt_ 
5. Run the following code in terminal [content in the bracket is optional]

```
python main.py --connect [--debug] [--port PORT]
```

## Options (main.py)
    -h, --help                           show this help message and exit

    --connect                            connect to the unity character

    --port PORT                          specify the port of the connection to 
                                         unity. Have to be the same as in Unity.

    --cam CAM                            specify the camera number to use 
                                         if you have multiple cameras connected
                                         to the computer.
                                         (for cv2.VideoCapture(CAM))

    --debug                              show the raw values of the detection 
                                         in the terminal

## Development Environment

- Python 3.10.0
- Numpy 1.19.2
- OpenCV 4.5.1
- Unity 2021.3.2f1

(For Windows, it is recommended to run this project using Anaconda (add to PATH in the system variables) and create a virtual environment before installing such packages.)

## To Do

- Implement a plug and play neurofeedback interface.
- Use neurofeedback to affect speed.

## Frequently Asked Questions

**Q: Why are there no questions here?**

A: People haven't yet asked me questions to populate this section.
