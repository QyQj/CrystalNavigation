# 🔮CrystalNavigation

CrystalNavigation is a simple navigation web app copy style from [DokiDokiWeb]("https://dokidokiweb.com") and implement configure ability by asp.net core

## 📦Deployment

### 🐋Docker

### ⚒️Dotnet Command Line

## ⚙️Configuration

All of the configuration stored at `BookmarkConfig` section in appsettings.json

### IconApiUrl 

`IconApiUrl` is the url for automatic getting website's favicon

### Title

`Title` is the text display on browser tab

### Slogan

`Slogan` is the text display at center top of the page

### BookmarkGroups

`BookmarkGroups` is an array of `BookmarkGroup` which has a `Name` and serval `Bookmark`

### Bookmark

`Bookmark` controls the display of url

- **Name** DisplayName
- **Url** Url to jump
- **Emoji** Emoji display after `Name`, when `Emoji` has a value, auto icon and custom icon will not work
- **CustomIconUrl** Url for custom icon
- **Note** `Note` will display after you click the bookmark button
 
## 🐢Online Config Is Comming Soon