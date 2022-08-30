<p>&nbsp;</p><p>Ability to access data in-game across platforms, save data in JSON and optionally encrypted.<br />
  <br />
Sample download: <a href="https://github.com/CetaceaWang/GameData/archive/refs/heads/main.zip" target="_blank">github</a><br />
  <br />
Example use:<br />
  <br />
1. After downloading, open it with Unity, and open the sample scene, 
click on the GameObject object, you can modify the content of TestData 
in Component &gt; File Settings.<br />
  <br />
2. After execution, click on the GameObject to modify the contents of TestData in Component &gt; Data Settings.<br />
  <br />
  <br />
  <a href="https://blogger.googleusercontent.com/img/a/AVvXsEiHd2umxEzlqwAxa_qCUb-bXbJ8ld4We_rbG_AcyPEDP2m5ebljArS5yLuRGotLWebLTkrPMtC-o8sihciwSK9tS0vkBijUCPJr6d_ZKkZKEBXJNR47tSgiHFgy2yoL4iSQ6DwPrOYR3vtTFb6hhTKr2kQJcAtKS1hWveDc2SAHGF5QqssUjQ6muBcKTQ" style="margin-left: 1em; margin-right: 1em;"><img alt="" data-original-height="557" data-original-width="393" height="240" src="https://blogger.googleusercontent.com/img/a/AVvXsEiHd2umxEzlqwAxa_qCUb-bXbJ8ld4We_rbG_AcyPEDP2m5ebljArS5yLuRGotLWebLTkrPMtC-o8sihciwSK9tS0vkBijUCPJr6d_ZKkZKEBXJNR47tSgiHFgy2yoL4iSQ6DwPrOYR3vtTFb6hhTKr2kQJcAtKS1hWveDc2SAHGF5QqssUjQ6muBcKTQ" width="169" /></a><br />
3. Stop the execution, you can see that the file is in <a href="https://docs.unity3d.com/ScriptReference/Application-persistentDataPath.html">Application.persistentDataPath</a>.<br />
  <a href="https://blogger.googleusercontent.com/img/a/AVvXsEj04K8pbvurkuJpYoIOl5Mnl7XokryXr0xF1mk6j3xjsoTM4tCuzaweXBDWZF1OzlEPyqANI8BoFl2UVdIvzO9Tn-3uvLFZwUoLVcmx2bPv_GX-nC5vzJADGm3UEiIGToEs6mh8No6KvbLrCOWIvj_3f3BRGTx3CB2zi1_P_JGX5FFfSoWdvk1k6NUs4w" style="margin-left: 1em; margin-right: 1em;"><img alt="" data-original-height="460" data-original-width="257" height="240" src="https://blogger.googleusercontent.com/img/a/AVvXsEj04K8pbvurkuJpYoIOl5Mnl7XokryXr0xF1mk6j3xjsoTM4tCuzaweXBDWZF1OzlEPyqANI8BoFl2UVdIvzO9Tn-3uvLFZwUoLVcmx2bPv_GX-nC5vzJADGm3UEiIGToEs6mh8No6KvbLrCOWIvj_3f3BRGTx3CB2zi1_P_JGX5FFfSoWdvk1k6NUs4w" width="134" /></a><br />
  <br />
4. Execute again, you can find that the content of TestData Component has changed.<br />
  <br />
Package download: <a href="https://github.com/CetaceaWang/GameData/archive/refs/heads/main.zip" target="_blank">github</a><br />
  <br />
Package use:<br />
  <br />
1. After opening Unity, go to Assets &gt; Import Package &gt; Custom Package to install.<br />
  <br />
2. Change the public class GameData in GameData.cs to the required data 
structure. Note that GameData() below should be modified accordingly. 
Note that the Dictionary should use SerializableDictionary. </p>
<p>demonstration:<br />
  <br />
&nbsp; public class GameData<br />
{<br />
&nbsp;&nbsp;&nbsp; public Vector3 playerPosition;<br />
&nbsp;&nbsp;&nbsp; public GameData()<br />
&nbsp;&nbsp;&nbsp; {<br />
&nbsp;&nbsp;&nbsp; this.playerPosition = Vector3.zero;<br />
&nbsp;&nbsp; }<br />
}<br />
  <br />
3. Read the file before use, it is recommended to put it in Start()<br />
  <br />
private FileDataHandler dataHandler;<br />
private void Start()<br />
{<br />
&nbsp;&nbsp;&nbsp;&nbsp; dataHandler = new FileDataHandler(Application.persistentDataPath, fileName, encryptionCodeWord);<br />
&nbsp;&nbsp;&nbsp;&nbsp; StaticGameData.gameData = dataHandler.Load();<br />
}<br />
  <br />
4. Read out the variables in the data, which can be read by any class.<br />
  <br />
playerPosition = StaticGameData.gameData.playerPosition;<br />
  <br />
5. Set the variables in the data, any class can set.<br />
  <br />
StaticGameData.gameData.playerPosition=playerPosition ;<br />
  <br />
6. Save file, it is recommended to put it in OnApplicationQuit()<br />
  <br />
dataHandler.Save(StaticGameData.gameData);</p>
