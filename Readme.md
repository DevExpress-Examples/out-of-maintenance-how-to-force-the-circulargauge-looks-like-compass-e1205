<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to force the CircularGauge looks like compass 


<p>1. Create a scale with the MinValue set to 0, and the MaxValue set to 360<br />
2. Handle the CustomTickmarkText event, to provide your direction letters (N,S,E,W)<br />
3. Assign the ArcScaleComponent.Value to provide the necessary needle position.</p>

<br/>


