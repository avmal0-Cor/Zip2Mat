# s2convert_tools

<!-- Оставлю в качестве замены в будущем | ![Zip2Mat Screenshot](https://user-images.githubusercontent.com/12881812/115393441-9b468f80-a1d9-11eb-94cf-88bf91183fca.png) -->

## Что это?

s2convert_tools в основном нацелен на эффективную конвертацию материалов. Пока программа работает посредством zip архивов, но планируется уйти от этого в пользу работы с единичным файлом/материалом.


s2convert_tools поддерживает то же, что и Zip2Mat, то есть:

- Automatically extracts & moves all of your files into the right place so that you don't have to
- Bulk importing: drag & drop multiple zip files so that you can batch import textures
- Converts textures into .tga images (Source 2 likes these more than jpegs or pngs or whatever)
- Support for the 'VR Simple' shader
- A super simple, intuitive interface
- Tested & works with CC0Textures, TextureCan, TextureHaven, among others (most of the [3dassets.one](https://3dassets.one/)
results should work without issue)
- Normalize file names (so that your project folder isnt a mess)

## Why?

Because I'm lazy and can't be bothered to link all of the maps up manually. And you probably don't either.

## Where?

You can [download the latest release](https://github.com/xezno/Zip2Mat/releases) with this repo's contents and compile it
yourself, or [download the zip](https://github.com/xezno/Zip2Mat/archive/refs/heads/main.zip).

**As a quick note**, don't bother using jpegs. Importing them into Source 2 causes the whole engine to hang for ~20 seconds,
and they look like shit anyway.

## How?

Zip2Mat simply searches for common aliases for the different map types (i.e. color -> colour, diffuse, col, albedo, etc.)
and then generates a vmat file using the T4 text template system.
