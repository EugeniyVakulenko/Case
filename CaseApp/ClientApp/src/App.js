import React, { Component } from 'react';
import { Layout } from './components/Layout';
import {MainComponent} from './components/MainComponent'

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={MainComponent} />
      </Layout>
    );
  }
}
