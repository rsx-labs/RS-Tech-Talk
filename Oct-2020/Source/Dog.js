import React, {Component} from 'react';
import {View, Text} from 'react-native';

class Dog extends Component {
  render() {
    return (
      <View>
        <Text>Hello I'm your dog {this.props.name}</Text>
      </View>
    );
  }
}

export default Dog;
