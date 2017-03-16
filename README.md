
# react-native-canvas

## Getting started

`$ npm install react-native-canvas --save`

### Mostly automatic installation

`$ react-native link react-native-canvas`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-canvas` and add `RNCanvas.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNCanvas.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNCanvasPackage;` to the imports at the top of the file
  - Add `new RNCanvasPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-canvas'
  	project(':react-native-canvas').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-canvas/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-canvas')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNCanvas.sln` in `node_modules/react-native-canvas/windows/RNCanvas.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Com.Reactlibrary.RNCanvas;` to the usings at the top of the file
  - Add `new RNCanvasPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNCanvas from 'react-native-canvas';

// TODO: What to do with the module?
RNCanvas;
```
  