#:package Microsoft.CodeAnalysis.CSharp@5.0.0


using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;

var file = args[0];
var code = await File.ReadAllTextAsync(file);

var tree = CSharpSyntaxTree.ParseText(code);
var root = tree.GetCompilationUnitRoot();

Console.WriteLine($"Lines: {code.Split('\n').Length}");
Console.WriteLine($"Classes: {root.DescendantNodes().OfType<ClassDeclarationSyntax>().Count()}");
