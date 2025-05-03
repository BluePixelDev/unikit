# Utilkit

[![GitHub Repo stars](https://img.shields.io/github/stars/BluePixelDev/utilkit?style=flat-square)](https://github.com/BluePixelDev/utilkit/stargazers)
[![GitHub last commit](https://img.shields.io/github/last-commit/BluePixelDev/utilkit?style=flat-square)](https://github.com/BluePixelDev/utilkit/commits/main)
[![GitHub issues](https://img.shields.io/github/issues/bluepixeldev/utilkit?style=flat-square)](https://github.com/bluepixeldev/utilkit/issues)
[![Unity Version](https://img.shields.io/badge/unity-6.0%2B-green?style=flat-square)](https://unity.com/releases/editor)

## Contents

### Utilities

* [LayerUtil](#layerutil)
* [Color Util](#colorutil)
* [ColliderUtil](#colliderutil)
* [WebColor](#webcolor)
* [Vec2Util](#vec2util)
* [Vec3Util](#vec3util)

## Utilities

### 1. **LayerUtil**

Utility methods for working with Unity `LayerMask` and layers.

* **ContainsLayer**

  ```csharp
  public static bool ContainsLayer(this LayerMask layerMask, int layer);
  ```

  Checks if a specific layer is included in the `LayerMask`.

* **IsInLayerMask**

  ```csharp
  public static bool IsInLayerMask(this GameObject gameObject, LayerMask layerMask);
  ```

  Determines if the `GameObject` is in the specified `LayerMask`.

* **AddLayer**

  ```csharp
  public static void AddLayer(ref this LayerMask layerMask, int layer);
  ```

  Adds a layer to the `LayerMask`.

* **RemoveLayer**

  ```csharp
  public static void RemoveLayer(ref this LayerMask layerMask, int layer);
  ```

  Removes a layer from the `LayerMask`.

### 2. **ColorUtil**

Provides extension methods for flexible manipulation of Unity's `Color` struct.

* **RGBA**

  ```csharp
  public static Color RGBA(this Color color, float? red = null, float? green = null, float? blue = null, float? alpha = null);
  ```

  Returns a new color with optional modifications to any of the RGBA channels.

* **Red, Green, Blue, Alpha**

  ```csharp
  public static Color Red(this Color color, float r);
  public static Color Green(this Color color, float g);
  public static Color Blue(this Color color, float b);
  public static Color Alpha(this Color color, float a);
  ```

  Return a new color with only the respective channel modified.

* **Lerp**

  ```csharp
  public static Color Lerp(this Color color1, Color color2, float t);
  ```

  Linearly interpolates between two colors.

* **ToGrayscale**

  ```csharp
  public static Color ToGrayscale(this Color color);
  ```

  Converts the color to grayscale.

* **Invert**

  ```csharp
  public static Color Invert(this Color color);
  ```

  Inverts the RGB channels of the color.

* **Multiply**

  ```csharp
  public static Color Multiply(this Color color, float multiplier);
  ```

  Multiplies the RGB channels by a given multiplier (clamped between 0 and 1).

### 3. **ColliderUtil**

Utility methods for working with Unity `Collider` and `Collision` objects to retrieve root `GameObject`.

* **Root (Collider2D)**

  ```csharp
  public static GameObject Root(this Collider2D collider);
  ```

  Gets the root `GameObject` from a `Collider2D`, prioritizing the attached `Rigidbody2D` if available.

* **Root (Collider)**

  ```csharp
  public static GameObject Root(this Collider collider);
  ```

  Gets the root `GameObject` from a `Collider`, prioritizing the attached `Rigidbody` if available.

* **Root (Collision)**

  ```csharp
  public static GameObject Root(this Collision collision);
  ```

  Gets the root `GameObject` from a `Collision`, prioritizing the associated `Rigidbody` if available.

* **Root (Collision2D)**

  ```csharp
  public static GameObject Root(this Collision2D collision);
  ```

  Gets the root `GameObject` from a `Collision2D`, prioritizing the associated `Rigidbody2D` if available.

### 4. **WebColor**

A static class containing all 140 web colors, providing a simple way to use web color codes in Unity.

* **Examples**

  ```csharp
  public static Color Black => ConvertHtmlString("#000000");
  public static Color Navy => ConvertHtmlString("#000080");
  public static Color DarkBlue => ConvertHtmlString("#00008B");
  public static Color MediumBlue => ConvertHtmlString("#0000CD");
  public static Color Blue => ConvertHtmlString("#0000FF");
  ```

### 5. **Vec2Util**

Utility methods for manipulating `Vector2` in Unity with additional operations and math functions.

#### Operations:

* **SetX, SetY**

  ```csharp
  public static Vector2 SetX(this ref Vector2 v, float x);
  public static Vector2 SetY(this Vector2 v, float y);
  ```

* **AddX, AddY, SubX, SubY**

  ```csharp
  public static Vector2 AddX(this Vector2 v, float add);
  public static Vector2 AddY(this Vector2 v, float add);
  public static Vector2 SubX(this Vector2 v, float sub);
  public static Vector2 SubY(this Vector2 v, float sub);
  ```

#### Math Methods:

* **Vec3**

  ```csharp
  public static Vector3 Vec3(this Vector2 v, float z = 0);
  ```

* **Multiply, Divide, Abs, Sign, OneMinus, Round, Clamp**

  ```csharp
  public static Vector2 Multiply(this Vector2 v, Vector2 vector);
  public static Vector3 Divide(this Vector2 v, Vector2 vector);
  public static Vector2 Abs(this Vector2 v);
  public static Vector2 Sign(this Vector2 v);
  public static Vector2 OneMinus(this Vector2 v);
  public static Vector2 Round(this Vector2 v);
  public static Vector2 Clamp(this Vector2 v, float min, float max);
  public static Vector2 Clamp(this Vector2 v, Vector2 minVector, Vector2 maxVector);
  ```

#### Random:

* **RandomVector2**

  ```csharp
  public static Vector2 RandomVector2(float min, float max);
  ```

  Generates a `Vector2` with random values in the specified range.

Great! Let's continue expanding the README file with the additional utilities you've provided.

### 6. **Vec3Util**

Utility methods for working with `Vector3` in Unity.

#### Operations:

* **SetX, SetY, SetZ**

  ```csharp
  public static Vector3 SetX(this Vector3 v, float x);
  public static Vector3 SetY(this Vector3 v, float y);
  public static Vector3 SetZ(this Vector3 v, float z);
  ```

  Set individual axes (X, Y, Z) of the `Vector3`.

* **Add, AddX, AddY, AddZ**

  ```csharp
  public static Vector3 Add(this Vector3 v, Vector2 vector);
  public static Vector3 AddX(this Vector3 v, float add);
  public static Vector3 AddY(this Vector3 v, float add);
  public static Vector3 AddZ(this Vector3 v, float add);
  ```

  Adds values to the `Vector3` axes, including adding a `Vector2` to `Vector3`.

* **Sub, SubX, SubY, SubZ**

  ```csharp
  public static Vector3 Sub(this Vector3 v, Vector2 vector);
  public static Vector3 SubX(this Vector3 v, float sub);
  public static Vector3 SubY(this Vector3 v, float sub);
  public static Vector3 SubZ(this Vector3 v, float sub);
  ```

  Subtracts values from the `Vector3` axes, including subtracting a `Vector2` from `Vector3`.

#### Math Methods:

* **Mul (Multiply), Div (Divide), Abs, Sign, OneMinus, Round**

  ```csharp
  public static Vector3 Mul(this Vector3 v, float value);
  public static Vector3 Mul(this Vector3 v, Vector3 vector);
  public static Vector3 Div(this Vector3 v, Vector3 vector);
  public static Vector3 Div(this Vector3 v, float value);
  public static Vector3 Abs(this Vector3 v);
  public static Vector3 Sign(this Vector3 v);
  public static Vector3 OneMinus(this Vector3 v);
  public static Vector3 Round(this Vector3 v);
  ```

  Provides mathematical operations for `Vector3`, such as multiplication, division, absolute values, signs, and rounding.

* **Clamp**

  ```csharp
  public static Vector3 Clamp(this Vector3 v, float min, float max);
  public static Vector3 Clamp(this Vector3 v, Vector3 minVector, Vector3 maxVector);
  ```

  Clamps each component of the `Vector3` to the specified value or range.

#### Conversion:

* **Vec2**

  ```csharp
  public static Vector2 Vec2(this Vector3 v);
  ```

  Converts a `Vector3` to a `Vector2`, discarding the Z axis.

#### Random:

* **RandomVector3**

  ```csharp
  public static Vector3 RandomVector3(float min, float max);
  ```

  Generates a `Vector3` with random values in the specified range for each axis.

* **RandomUnitVector3**

  ```csharp
  public static Vector3 RandomUnitVector3();
  ```

  Generates a random unit vector (normalized) with values between -1 and 1.


### 7. **NullFunc**

Provides null-check utilities for objects and actions to prevent null reference exceptions.

* **WithNotNull (Action<T>)**

  ```csharp
  public static void WithNotNull<T>(this T target, Action<T> action);
  ```

  Invokes the specified action if the target is not null.

* **WithNotNull (Action)**

  ```csharp
  public static void WithNotNull<T>(this T target, Action action);
  ```

  Invokes the specified action if the target is not null.

* **WithNull (Action<T>)**

  ```csharp
  public static void WithNull<T>(this T target, Action<T> action);
  ```

  Invokes the specified action if the target is null.

* **WithNull (Action)**

  ```csharp
  public static void WithNull<T>(this T target, Action action);
  ```

  Invokes the specified action if the target is null.

* **IsNull**

  ```csharp
  public static bool IsNull<T>(this T target);
  ```

  Checks if the target is null or destroyed.


### 8. **Gizmos2D**

A set of utilities for drawing 2D shapes in the Unity Editor using Gizmos.

* **DrawWireCircle**

  ```csharp
  public static void DrawWireCircle(Vector3 position, float radius);
  ```

  Draws a wireframe circle on the XY plane at the specified position and radius.

* **DrawCircle**

  ```csharp
  public static void DrawCircle(Vector3 position, float radius);
  ```

  Draws a filled circle on the XY plane at the specified position and radius.

* **DrawSquare**

  ```csharp
  public static void DrawSquare(Vector3 position, Vector2 size);
  ```

  Draws a square at the specified position with the given size.

* **DrawCone**

  ```csharp
  public static void DrawCone(Vector3 position, float radius, float angle);
  ```

  Draws a cone shape at the specified position with the given radius and angle.

### 9. **GizmoUtil**

A set of utilities for drawing 3D shapes in the Unity Editor using Gizmos.

* **DrawCylinder**

  ```csharp
  public static void DrawCylinder(Vector3 center, float radius, float height);
  ```

  Draws a cylinder at the specified center position with the given radius and height.

* **DrawCircle**

  ```csharp
  public static void DrawCircle(Vector3 center, float radius);
  ```

  Draws a circle at the specified center position with the given radius.

* **DrawPolyLine**

  ```csharp
  public static void DrawPolyLine(params Vector3[] points);
  ```

  Draws a polyline using the given points.
