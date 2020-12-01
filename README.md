# unity-tilemapcollider2d-tester
Test project to understand TilemapCollider2D collisions (or for reporting a bug if there is one).

This project has been built in Unity 2020.1 and tested on macOS Catalina (10.15.7).

This repo is referenced by Unity forum question [Weird behaviour on TilemapCollider2D](https://forum.unity.com/threads/weird-behaviour-on-tilemapcollider2d.1012402/).

Here are the strange behaviours I'm seeing. Note the contact points appear to be correct at first contact between the circle and a tile but then veer off such that they're not on either collider's edge. In some cases, they even move outside the tile they refer to.

## Screengrab focusing on the circle
![alt text](TilemapCollider2D-focus-on-circle-(20s).gif "Screengrab focusing on the circle")

## Screengrab focusing on the tilemap
![alt text](TilemapCollider2D-focus-on-tilemap-(20s).gif "Screengrab focusing on the tilemap")
