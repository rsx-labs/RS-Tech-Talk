import React, {Component, useState} from 'react';
import {View, Text, Button} from 'react-native';
import Dog from './Dog';

const appName = 'TechTalkProject';

function App() {
  const [count, adjustCount] = useState(0);
  return (
    <View>
      <Text>Hello world!</Text>
      <Text>{appName}</Text>
      <Dog name="Pampu" />
      <Text>{count}</Text>
      <Button title="Add" onPress={() => adjustCount(count + 1)} />
      <Button title="Decrease" onPress={() => adjustCount(count - 1)} />
    </View>
  );
}

export default App;
