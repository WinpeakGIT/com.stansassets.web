# Web API
Contains JSON based abstract web service implementation. See samples and wiki for more information.

[![NPM Package](https://img.shields.io/npm/v/com.stansassets.web)](https://www.npmjs.com/package/com.stansassets.web)
[![openupm](https://img.shields.io/npm/v/com.stansassets.web?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.stansassets.web/)
[![Licence](https://img.shields.io/npm/l/com.stansassets.web)](https://github.com/StansAssets/com.stansassets.web/blob/master/LICENSE)
[![Issues](https://img.shields.io/github/issues/StansAssets/com.stansassets.web)](https://github.com/StansAssets/com.stansassets.web/issues)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/a22ff0164da04d089f68d8209dbe6c10)](https://app.codacy.com/gh/StansAssets/com.stansassets.web?utm_source=github.com&utm_medium=referral&utm_content=StansAssets/com.stansassets.web&utm_campaign=Badge_Grade_Dashboard)


### Install from NPM
* Navigate to the `Packages` directory of your project.
* Adjust the [project manifest file](https://docs.unity3d.com/Manual/upm-manifestPrj.html) `manifest.json` in a text editor.
* Ensure `https://registry.npmjs.org/` is part of `scopedRegistries`.
  * Ensure `com.stansassets` is part of `scopes`.
  * Add `com.stansassets.web` to the `dependencies`, stating the latest version.

A minimal example ends up looking like this. Please note that the version `X.Y.Z` stated here is to be replaced with [the latest released version](https://www.npmjs.com/package/com.stansassets.web) which is currently [![NPM Package](https://img.shields.io/npm/v/com.stansassets.web)](https://www.npmjs.com/package/com.stansassets.web).
  ```json
  {
    "scopedRegistries": [
      {
        "name": "npmjs",
        "url": "https://registry.npmjs.org/",
        "scopes": [
          "com.stansassets"
        ]
      }
    ],
    "dependencies": {
      "com.stansassets.web": "X.Y.Z",
      ...
    }
  }
  ```
* Switch back to the Unity software and wait for it to finish importing the added package.

### Install from OpenUPM
* Install openupm-cli `npm install -g openupm-cli` or `yarn global add openupm-cli`
* Enter your unity project folder `cd <YOUR_UNITY_PROJECT_FOLDER>`
* Install package `openupm add com.stansassets.web`

### Install from a Git URL
Yoy can also install this package via Git URL. To load a package from a Git URL:

* Open [Unity Package Manager](https://docs.unity3d.com/Manual/upm-ui.html) window.
* Click the add **+** button in the status bar.
* The options for adding packages appear.
* Select Add package from git URL from the add menu. A text box and an Add button appear.
* Enter the `https://github.com/StansAssets/com.stansassets.web.git` Git URL in the text box and click Add.
* You may also install a specific package version by using the URL with the specified version.
  * `https://github.com/StansAssets/com.stansassets.web.git#X.Y.X`
  * Please note that the version `X.Y.Z` stated here is to be replaced with the version you would like to get.
  * You can find all the available releases [here](https://github.com/StansAssets/com.stansassets.web/releases).
  * The latest available release version is [![Last Release](https://img.shields.io/github/v/release/stansassets/com.stansassets.web)](https://github.com/StansAssets/com.stansassets.web/releases/latest)

For more information about what protocols Unity supports, see [Git URLs](https://docs.unity3d.com/Manual/upm-git.html).

## About Us
We are committed to developing high quality and engaging entertainment software. Our mission has been to bring a reliable and high-quality Unity Development service to companies and individuals around the globe. 
At Stan's Assets, we make Plugins, SDKs, Games, VR & AR Applications. Do not hesitate do get in touch, whether you have a question, want to build something, or just to say hi :) [Let's Talk!](mailto:stan@stansassets.com)

[Website](https://stansassets.com/) | [LinkedIn](https://www.linkedin.com/in/lacost/) | [Youtube](https://www.youtube.com/user/stansassets/videos) | [Github](https://github.com/StansAssets) | [AssetStore](https://assetstore.unity.com/publishers/2256)
