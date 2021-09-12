using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionScript
{
    [SerializeField]
    enum Direction
    {
        ZERO,
        UP,
        RIGHT,
        DOWN,
        LEFT
    }
    [SerializeField] Direction direction;

    int indexGuiltyDirection;
    [SerializeField] bool check = false;

    public bool InputCheck(int index)
    {
        switch (index)
        {
            case 1:
                {
                    if (!isBackward(Direction.UP) || check && indexGuiltyDirection != 1)
                    {
                        return ChangeDir(Direction.UP);
                    }
                    break;
                }
            case 3:
                {
                    if (!isBackward(Direction.DOWN) || check && indexGuiltyDirection != 3)
                    {
                        return ChangeDir(Direction.DOWN);
                    }
                    break;
                }
            case 2:
                {
                    if (!isBackward(Direction.RIGHT) || check && indexGuiltyDirection != 2)
                    {
                        return ChangeDir(Direction.RIGHT);
                    }
                    break;
                }
            case 4:
                {
                    if (!isBackward(Direction.LEFT) || check && indexGuiltyDirection != 4)
                    {
                        return ChangeDir(Direction.LEFT);
                    }
                    break;
                }
            case 0:
                {
                    if (!check)
                    {
                        direction = Direction.ZERO;
                    }
                    break;
                }
        }
        return false;
    }
    bool ChangeDir(Direction dir)
    {
        if (check)
        {
            check = isBackward(dir);
        }
        if (direction != dir)
        {
            direction = dir;
        }

        return true;
    }

    public void GuiltyDirection()
    {
        check = true;
        indexGuiltyDirection = (int)direction;
    }

    bool isVertical(Direction direction)
    {
        if (direction == Direction.ZERO)
        {
            return false;
        }
        return direction == Direction.UP || direction == Direction.DOWN;
    }

    bool isHorizontal(Direction direction)
    {
        if (direction == Direction.ZERO)
        {
            return false;
        }
        return direction == Direction.LEFT || direction == Direction.RIGHT;
    }
    bool isBackward(Direction direction)
    {
        return isHorizontal(this.direction) && isHorizontal(direction) || isVertical(this.direction) && isVertical(direction);
    }
}
