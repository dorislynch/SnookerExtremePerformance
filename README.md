
# react-native-snooker-extreme-performance

## Getting started

`$ npm install react-native-snooker-extreme-performance --save`

### Mostly automatic installation

`$ react-native link react-native-snooker-extreme-performance`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-snooker-extreme-performance` and add `RNSnookerExtremePerformance.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNSnookerExtremePerformance.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNSnookerExtremePerformancePackage;` to the imports at the top of the file
  - Add `new RNSnookerExtremePerformancePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-snooker-extreme-performance'
  	project(':react-native-snooker-extreme-performance').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-snooker-extreme-performance/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-snooker-extreme-performance')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNSnookerExtremePerformance.sln` in `node_modules/react-native-snooker-extreme-performance/windows/RNSnookerExtremePerformance.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Snooker.Extreme.Performance.RNSnookerExtremePerformance;` to the usings at the top of the file
  - Add `new RNSnookerExtremePerformancePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNSnookerExtremePerformance from 'react-native-snooker-extreme-performance';

// TODO: What to do with the module?
RNSnookerExtremePerformance;
```
  