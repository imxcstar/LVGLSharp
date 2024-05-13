using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

ConsoleDriver.Run(new LVGLILibrary());

public class LVGLILibrary : ILibrary
{
    public void Postprocess(Driver driver, ASTContext ctx)
    {
    }

    public void Preprocess(Driver driver, ASTContext ctx)
    {
        foreach (var translationUnit in ctx.TranslationUnits)
        {
            if (!translationUnit.FileName.StartsWith("lv") && translationUnit.FileName.StartsWith("_lv"))
            {
                translationUnit.Ignore = true;
                continue;
            }
            foreach (var declarations in translationUnit.Declarations)
            {
                if ((!declarations.Name.StartsWith("lv") && !declarations.Name.StartsWith("_lv")) || declarations.DebugText.Contains("static"))
                {
                    declarations.Ignore = true;
                    continue;
                }
            }
        }
    }

    public void Setup(Driver driver)
    {
        var options = driver.Options;
        options.GeneratorKind = GeneratorKind.CSharp;
        options.OutputDir = @"../../../../../src/LVGLSharp.Native/Generate";

        var module = options.AddModule("lvgl");
        module.IncludeDirs.Add(@"../../../../../libs/lv_port_pc_visual_studio/LvglPlatform");
        module.IncludeDirs.Add(@"../../../../../libs/lv_port_pc_visual_studio/LvglPlatform/lvgl");
        module.IncludeDirs.Add(@"../../../../../libs/lv_port_pc_visual_studio/LvglWindows");
        module.Headers.Add("lv_conf.h");
        module.Headers.Add("lvgl.h");
    }

    public void SetupPasses(Driver driver)
    {
    }
}