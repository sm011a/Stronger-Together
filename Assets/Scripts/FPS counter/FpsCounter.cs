using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsCounter : MonoBehaviour
{
    [SerializeField]
    private int frameRange = 60;

    private int[] fpsBuffer;
    private int fpsBufferIndex;

    public int AverageFPS { get; private set; }
    public int HighestFPS { get; private set; }
    public int LowersFPS { get; private set; }

    private void Update()
    {
        if (fpsBuffer == null || frameRange != fpsBuffer.Length)
        {
            InitializeBuffer();
        }

        UpdateBuffer();
        CalculateFps();
    }

    private void InitializeBuffer()
    {
        if (frameRange <= 0)
        {
            frameRange = 1;
        }

        fpsBuffer = new int[frameRange];
        fpsBufferIndex = 0;
    }

    private void UpdateBuffer()
    {
        fpsBuffer[fpsBufferIndex++] = (int)(1f / Time.unscaledDeltaTime);
        if (fpsBufferIndex >= frameRange)
        {
            fpsBufferIndex = 0;
        }
    }

    private void CalculateFps()
    {
        int sum = 0;
        int lowest = int.MaxValue;
        int highest = 0;
        for (int i = 0; i < frameRange; i++)
        {
            int fps = fpsBuffer[i];
            sum += fps;
            if (fps > highest)
            {
                highest = fps;
            }

            if (fps < lowest)
            {
                lowest = fps;
            }
        }
        HighestFPS = highest;
        LowersFPS = lowest;
        AverageFPS = sum / frameRange;
    }
}
