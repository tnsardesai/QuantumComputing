#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_Zero_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":8,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_Zero_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":8,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_Zero_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":8,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":6},\"Item2\":{\"Line\":2,\"Column\":9}},\"Documentation\":[\"automatically generated QsAdjoint specialization for deutsch_jozsa.Oracle_Zero_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_One_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_One_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_One_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":6},\"Item2\":{\"Line\":2,\"Column\":9}},\"Documentation\":[\"automatically generated QsAdjoint specialization for deutsch_jozsa.Oracle_One_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_OddNumberOfOnes_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_OddNumberOfOnes_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_OddNumberOfOnes_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for deutsch_jozsa.Oracle_OddNumberOfOnes_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_Kth_Qubit_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":64}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_Kth_Qubit_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_Kth_Qubit_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for deutsch_jozsa.Oracle_Kth_Qubit_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_ProductFunction_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":37,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"r\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":70}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_ProductFunction_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":37,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"Oracle_ProductFunction_Reference\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":37,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for deutsch_jozsa.Oracle_ProductFunction_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"DeutschJozsa\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":50,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"DeutschJozsa\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":50,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"BernsteinVazirani\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":88,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"BernsteinVazirani\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":88,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"AssertDJAlgorithmWorks\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":116,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"expected\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":89}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"msg\"]},\"Type\":{\"Case\":\"String\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":98},\"Item2\":{\"Line\":1,\"Column\":101}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Bool\"},{\"Case\":\"String\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"AssertDJAlgorithmWorks\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":116,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"RunDeutschJozsa\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":120,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"RunDeutschJozsa\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":120,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"RunBernsteinVazirani\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":130,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"deutsch_jozsa\",\"Name\":\"RunBernsteinVazirani\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs\",\"Position\":{\"Item1\":130,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
#line hidden
namespace deutsch_jozsa
{
    public class Oracle_Zero_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_Zero_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_Zero_Reference";
        String ICallable.FullName => "deutsch_jozsa.Oracle_Zero_Reference";
        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_Zero_Reference, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class Oracle_One_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_One_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_One_Reference";
        String ICallable.FullName => "deutsch_jozsa.Oracle_One_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 20 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            MicrosoftQuantumIntrinsicX.Apply(y);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(y);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_One_Reference, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class Oracle_OddNumberOfOnes_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_OddNumberOfOnes_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_OddNumberOfOnes_Reference";
        String ICallable.FullName => "deutsch_jozsa.Oracle_OddNumberOfOnes_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 26 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            foreach (var q in x)
#line hidden
            {
#line 27 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((q, y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            foreach (var q in x?.Slice(new Range((x.Length - 1L), -1L, 0L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((q, y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_OddNumberOfOnes_Reference, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class Oracle_Kth_Qubit_Reference : Adjointable<(IQArray<Qubit>,Qubit,Int64)>, ICallable
    {
        public Oracle_Kth_Qubit_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_Kth_Qubit_Reference";
        String ICallable.FullName => "deutsch_jozsa.Oracle_Kth_Qubit_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (x,y,k) = __in__;
#line 34 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((((0L <= k) && (k < x.Length)), true, "k should be between 0 and N-1, inclusive"));
#line 35 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((x[k], y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,k) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((((0L <= k) && (k < x.Length)), true, "k should be between 0 and N-1, inclusive"));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[k], y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, Int64 k)
        {
            return __m__.Run<Oracle_Kth_Qubit_Reference, (IQArray<Qubit>,Qubit,Int64), QVoid>((x, y, k));
        }
    }

    public class Oracle_ProductFunction_Reference : Adjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, ICallable
    {
        public Oracle_ProductFunction_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_ProductFunction_Reference";
        String ICallable.FullName => "deutsch_jozsa.Oracle_ProductFunction_Reference";
        protected ICallable MicrosoftQuantumArraysIndexRange
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (x,y,r) = __in__;
#line 42 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((x.Length, r.Length, "Arrays should have the same length"));
#line 44 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            foreach (var i in MicrosoftQuantumArraysIndexRange.Apply<Range>(x))
#line hidden
            {
#line 45 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                if ((r[i] == 1L))
                {
#line 46 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,r) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((x.Length, r.Length, "Arrays should have the same length"));
#line hidden
            foreach (var i in RangeReverse.Apply(MicrosoftQuantumArraysIndexRange.Apply<Range>(x)))
#line hidden
            {
#line hidden
                if ((r[i] == 1L))
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[i], y));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysIndexRange = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.IndexRange<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, IQArray<Int64> r)
        {
            return __m__.Run<Oracle_ProductFunction_Reference, (IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>((x, y, r));
        }
    }

    public class DeutschJozsa : Operation<(Int64,ICallable), Boolean>, ICallable
    {
        public DeutschJozsa(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "DeutschJozsa";
        String ICallable.FullName => "deutsch_jozsa.DeutschJozsa";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), Boolean> Body => (__in__) =>
        {
            var (N,Uf) = __in__;
#line 52 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            var result = true;
#line hidden
            {
#line 53 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                var (x,b) = (Allocate.Apply(N), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 55 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicH, x));
#line 56 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(b);
#line 57 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumIntrinsicH.Apply(b);
#line 59 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    Uf.Apply((x, b));
#line 61 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicH, x));
#line 63 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    var r = QArray<Int64>.Create(N);
#line 69 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                    {
#line 70 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(x[i]) != Result.Zero))
                        {
#line 71 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                            r.Modify(i, 1L);
                        }
                    }

#line 79 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                    {
#line 80 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                        result = (result && (r[i] == 0L));
                    }

#line 82 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(x);
#line 83 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(b);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(x);
#line hidden
                    Release.Apply(b);
                }
            }

#line 85 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<DeutschJozsa, (Int64,ICallable), Boolean>((N, Uf));
        }
    }

    public class BernsteinVazirani : Operation<(Int64,ICallable), IQArray<Int64>>, ICallable
    {
        public BernsteinVazirani(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "BernsteinVazirani";
        String ICallable.FullName => "deutsch_jozsa.BernsteinVazirani";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), IQArray<Int64>> Body => (__in__) =>
        {
            var (N,Uf) = __in__;
#line 90 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            var result = true;
#line hidden
            {
#line 91 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                var (x,b) = (Allocate.Apply(N), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 93 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicH, x));
#line 94 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(b);
#line 95 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumIntrinsicH.Apply(b);
#line 97 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    Uf.Apply((x, b));
#line 99 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicH, x));
#line 101 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    var r = QArray<Int64>.Create(N);
#line 103 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                    {
#line 104 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(x[i]) != Result.Zero))
                        {
#line 105 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                            r.Modify(i, 1L);
                        }
                    }

#line 109 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(x);
#line 110 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(b);
#line 112 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
                    return r;
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(x);
#line hidden
                    Release.Apply(b);
                }
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<BernsteinVazirani, (Int64,ICallable), IQArray<Int64>>((N, Uf));
        }
    }

    public class AssertDJAlgorithmWorks : Operation<(Int64,ICallable,Boolean,String), QVoid>, ICallable
    {
        public AssertDJAlgorithmWorks(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable,Boolean,String)>, IApplyData
        {
            public In((Int64,ICallable,Boolean,String) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "AssertDJAlgorithmWorks";
        String ICallable.FullName => "deutsch_jozsa.AssertDJAlgorithmWorks";
        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), Boolean> DeutschJozsa
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable,Boolean,String), QVoid> Body => (__in__) =>
        {
            var (N,oracle,expected,msg) = __in__;
#line 118 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((DeutschJozsa.Apply((N, oracle)), expected, msg));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.DeutschJozsa = this.Factory.Get<ICallable<(Int64,ICallable), Boolean>>(typeof(DeutschJozsa));
        }

        public override IApplyData __dataIn((Int64,ICallable,Boolean,String) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, ICallable oracle, Boolean expected, String msg)
        {
            return __m__.Run<AssertDJAlgorithmWorks, (Int64,ICallable,Boolean,String), QVoid>((N, oracle, expected, msg));
        }
    }

    public class RunDeutschJozsa : Operation<Int64, IQArray<Boolean>>, ICallable
    {
        public RunDeutschJozsa(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RunDeutschJozsa";
        String ICallable.FullName => "deutsch_jozsa.RunDeutschJozsa";
        protected ICallable<(Int64,ICallable,Boolean,String), QVoid> AssertDJAlgorithmWorks
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), Boolean> DeutschJozsa
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,Int64)> Oracle_Kth_Qubit_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_OddNumberOfOnes_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_One_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_Zero_Reference
        {
            get;
            set;
        }

        public override Func<Int64, IQArray<Boolean>> Body => (__in__) =>
        {
            var N = __in__;
#line 122 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            var result = QArray<Boolean>.Create(4L);
#line 123 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            AssertDJAlgorithmWorks.Apply((4L, Oracle_Zero_Reference, false, "f(x) = 0 not identified as constant"));
#line 124 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            result.Modify(0L, DeutschJozsa.Apply((N, Oracle_Zero_Reference)));
#line 125 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            result.Modify(1L, DeutschJozsa.Apply((N, Oracle_One_Reference)));
#line 126 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            result.Modify(2L, DeutschJozsa.Apply((N, Oracle_OddNumberOfOnes_Reference)));
#line 127 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            result.Modify(3L, DeutschJozsa.Apply((N, Oracle_Kth_Qubit_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,Int64)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, 1L))))));
#line 128 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.AssertDJAlgorithmWorks = this.Factory.Get<ICallable<(Int64,ICallable,Boolean,String), QVoid>>(typeof(AssertDJAlgorithmWorks));
            this.DeutschJozsa = this.Factory.Get<ICallable<(Int64,ICallable), Boolean>>(typeof(DeutschJozsa));
            this.Oracle_Kth_Qubit_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,Int64)>>(typeof(Oracle_Kth_Qubit_Reference));
            this.Oracle_OddNumberOfOnes_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_OddNumberOfOnes_Reference));
            this.Oracle_One_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_One_Reference));
            this.Oracle_Zero_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_Zero_Reference));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__, Int64 N)
        {
            return __m__.Run<RunDeutschJozsa, Int64, IQArray<Boolean>>(N);
        }
    }

    public class RunBernsteinVazirani : Operation<QVoid, IQArray<Int64>>, ICallable
    {
        public RunBernsteinVazirani(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RunBernsteinVazirani";
        String ICallable.FullName => "deutsch_jozsa.RunBernsteinVazirani";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), IQArray<Int64>> BernsteinVazirani
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_ProductFunction_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, IQArray<Int64>> Body => (__in__) =>
        {
#line 132 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            var oracle = Oracle_ProductFunction_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, new QArray<Int64>(1L, 1L, 1L, 0L))));
#line 133 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            var result = new QArray<Int64>(BernsteinVazirani.Apply((new QArray<Int64>(1L, 1L, 1L, 0L).Length, oracle)));
#line 134 "/Users/arnavgarg/Desktop/code/personal/quantum_applications/ignore/deutsch_jozsa/Operations.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.BernsteinVazirani = this.Factory.Get<ICallable<(Int64,ICallable), IQArray<Int64>>>(typeof(BernsteinVazirani));
            this.Oracle_ProductFunction_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_ProductFunction_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__)
        {
            return __m__.Run<RunBernsteinVazirani, QVoid, IQArray<Int64>>(QVoid.Instance);
        }
    }
}