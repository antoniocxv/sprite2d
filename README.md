# sprite2d
Exercise introduction to unity 2d. Sprites

![exercise](https://github.com/antoniocxv/sprite2d/blob/main/gifs/ejercicio.gif)

This work has several parts that we are going to detail in the following lines:

### - Movement and animation of the goblin
**Script: GoblinMovement**
Our goblin has different skills:<img width="auto" alt="image" src="https://github.com/antoniocxv/sprite2d/assets/6523949/66080e7d-b607-4105-a0ce-aad841242f45">
With them we can control the strength, jump and velocity. We have a flag to control if the goblin is jumping, that activates when jumping and deactivates when he has a collide with the floor or zombie ("suelo" and "zombie" tags)
<img width="auto" alt="image" src="https://github.com/antoniocxv/sprite2d/assets/6523949/c892aa19-2ed8-4568-abe3-699b5fa68809">

**Script: colisionZombie and Zombie**
The strength is necessary to kill the zombie. In this case the zombie has 100 points of life, and the goblin 50 strength to kill in two collisions. The zombie will reproduce a dead animation 
<img width="auto" alt="image" src="https://github.com/antoniocxv/sprite2d/assets/6523949/c5acdca9-80c0-4dab-8765-310c11ae68bd">

<img width="auto" alt="image" src="https://github.com/antoniocxv/sprite2d/assets/6523949/fcaf6a5a-6254-4e52-b61a-5d79dfffdf6d">

One detail I have found is that i need to freeze rotation in Z in the rigidbody, if not, the two objects rotates when collisioning.
