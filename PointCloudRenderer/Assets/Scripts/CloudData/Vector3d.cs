﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CloudData {
    /* A double-Vector
     */
    public class Vector3d {
        public double x, y, z;

        public Vector3d(double x, double y, double z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3d(Vector3 original) {
            this.x = original.x;
            this.y = original.y;
            this.z = original.z;
        }

        public double Length() {
            return Math.Sqrt(x * x + y*y + z * z);
        }

        public Vector3 ToFloatVector() {
            return new Vector3((float)x, (float)y, (float)z);
        }

        public double Distance(Vector3d other) {
            return (this - other).Length();
        }

        public Vector3d Normalize() {
            return this / Length();
        }

        public static Vector3d operator /(Vector3d v, double divisor) {
            return new Vector3d(v.x / divisor, v.y / divisor, v.z / divisor);
        }

        public static Vector3d operator +(Vector3d a, Vector3d b) {
            return new Vector3d(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector3d operator -(Vector3d a, Vector3d b) {
            return new Vector3d(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        //DOT-Product
        public static double operator *(Vector3d a, Vector3d b) {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        public override string ToString() {
            return "Vector3d [" + x + ", " + y + ", " + z + "]";
        }
    }
}