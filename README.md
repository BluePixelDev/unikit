# Utilkit

[![GitHub Repo stars](https://img.shields.io/github/stars/BluePixelDev/utilkit?style=flat-square)](https://github.com/BluePixelDev/utilkit/stargazers)
[![GitHub last commit](https://img.shields.io/github/last-commit/BluePixelDev/utilkit?style=flat-square)](https://github.com/BluePixelDev/utilkit/commits/main)
[![GitHub issues](https://img.shields.io/github/issues/bluepixeldev/utilkit?style=flat-square)](https://github.com/bluepixeldev/utilkit/issues)
[![Unity Version](https://img.shields.io/badge/unity-6.0%2B-green?style=flat-square)](https://unity.com/releases/editor)

`Utilkit` is a collection of helpful utilities for Unity development. It includes a variety of helper functions and extensions for `Vector3`, `Vector2`, and more, as well as utilities for drawing gizmos and handling null checks.

## Features

* **Vector3 Utilities**: Extensions for basic vector operations like setting individual axes, adding, subtracting, and math functions (multiply, divide, clamp, etc.)
* **Null Check Utilities**: Simplified methods for checking and invoking actions on objects that are either null or not null.
* **Gizmos Utilities**: Tools to draw 2D and 3D shapes (e.g., circles, squares, cones, cylinders) using Gizmos in the Unity editor.

## Installation

### Method 1: Unity Package Manager (UPM)

To use `Utilkit`, add the following to your `Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.bluepixel.utilkit": "https://github.com/bluepixeldev/utilkit.git"
  }
}
````

### Method 2: Manual Download

1. Download the repository as a ZIP file or clone it.
2. Add the contents of the `BP.Utilkit` folder to your Unity project's `Assets` directory.

## Usage

You can start using the utilities in your project by including the namespaces:

```csharp
using BP.Utilkit;
```

### Example Usage:

#### Vector3 Utilities:

```csharp
Vector3 v = new Vector3(1, 2, 3);
v = v.SetX(5);
v = v.Add(new Vector2(1, 1));
v = v.Mul(2);
```

#### Null Check Utilities:

```csharp
myObject.WithNotNull(obj => obj.DoSomething());
myObject.WithNull(() => Debug.Log("Object is null"));
```

#### Gizmos Utilities:

```csharp
void OnDrawGizmos() {
    Gizmos2D.DrawWireCircle(transform.position, 2);
    GizmoUtil.DrawCylinder(transform.position, 1, 5);
}
```

## Documentation

Detailed documentation is available in the [GitHub Wiki](https://github.com/BluePixelDev/utilkit/wiki).

## Contributing

Contributions are welcome! Feel free to submit issues and pull requests.

1. Fork the repository.
2. Create your feature branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a pull request.