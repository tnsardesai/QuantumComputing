#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"ApplyOracleA\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"ApplyOracleA\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"ApplyOracleA\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.SimonsAlgorithm.ApplyOracleA\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"ApplyOracleWithOutputArrA\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":58}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outputSize\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":98},\"Item2\":{\"Line\":1,\"Column\":108}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"ApplyOracleWithOutputArrA\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"ApplyOracleWithOutputArrA\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.SimonsAlgorithm.ApplyOracleWithOutputArrA\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"AssertTwoOraclesAreEqual\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Range\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":9},\"Item2\":{\"Line\":4,\"Column\":16}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Range\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"AssertTwoOraclesAreEqual\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"AssertTwoOraclesWithOutputArrAreEqual\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputSize\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":18}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outputSize\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":9},\"Item2\":{\"Line\":4,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":9},\"Item2\":{\"Line\":5,\"Column\":16}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"AssertTwoOraclesWithOutputArrAreEqual\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"Q11_Oracle_CountBits_Test\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"Q11_Oracle_CountBits_Test\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"Q12_Oracle_BitwiseRightShift_Test\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"Q12_Oracle_BitwiseRightShift_Test\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"AssertTwoOraclesWithIntArrAreEqual\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"A\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":110},\"Item2\":{\"Line\":1,\"Column\":117}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"AssertTwoOraclesWithIntArrAreEqual\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"Q13_Oracle_OperatorOutput_Test\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"Q13_Oracle_OperatorOutput_Test\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"AssertTwoOraclesWithIntMatrixAreEqual\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":99,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"A\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":10}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":9},\"Item2\":{\"Line\":4,\"Column\":16}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"AssertTwoOraclesWithIntMatrixAreEqual\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":99,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"AssertTwoOraclesWithDifferentOutputsAreEqual\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":55}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputSize\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":18}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":9},\"Item2\":{\"Line\":4,\"Column\":16}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"AssertTwoOraclesWithDifferentOutputsAreEqual\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":55}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"Q14_Oracle_MultidimensionalOperatorOutput_Test\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":119,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":57}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"Q14_Oracle_MultidimensionalOperatorOutput_Test\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":119,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":57}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"Q21_StatePrep_Test\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":144,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"Q21_StatePrep_Test\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":144,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"cs_helper\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Matrix\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SimonsAlgorithm\",\"Name\":\"cs_helper\"},\"SourceFile\":\"/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.SimonsAlgorithm
{
    public partial class ApplyOracleA : Adjointable<(IQArray<Qubit>,IAdjointable)>, ICallable
    {
        public ApplyOracleA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IAdjointable)>, IApplyData
        {
            public In((IQArray<Qubit>,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyOracleA";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.ApplyOracleA";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (qs,oracle) = __in__;
#line 18 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var N = qs.Length;
#line 19 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            oracle.Apply((qs?.Slice(new Range(0L, (N - 2L))), qs[(N - 1L)]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IAdjointable), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,oracle) = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            oracle.Adjoint.Apply((qs?.Slice(new Range(0L, (N - 2L))), qs[(N - 1L)]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, IAdjointable oracle)
        {
            return __m__.Run<ApplyOracleA, (IQArray<Qubit>,IAdjointable), QVoid>((qs, oracle));
        }
    }

    public partial class ApplyOracleWithOutputArrA : Adjointable<(IQArray<Qubit>,IAdjointable,Int64)>, ICallable
    {
        public ApplyOracleWithOutputArrA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IAdjointable,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,IAdjointable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyOracleWithOutputArrA";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.ApplyOracleWithOutputArrA";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IAdjointable,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,oracle,outputSize) = __in__;
#line 25 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var N = qs.Length;
#line 26 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            oracle.Apply((qs?.Slice(new Range(0L, ((N - 1L) - outputSize))), qs?.Slice(new Range((N - outputSize), (N - 1L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IAdjointable,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,oracle,outputSize) = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            oracle.Adjoint.Apply((qs?.Slice(new Range(0L, ((N - 1L) - outputSize))), qs?.Slice(new Range((N - outputSize), (N - 1L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IAdjointable,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, IAdjointable oracle, Int64 outputSize)
        {
            return __m__.Run<ApplyOracleWithOutputArrA, (IQArray<Qubit>,IAdjointable,Int64), QVoid>((qs, oracle, outputSize));
        }
    }

    public partial class AssertTwoOraclesAreEqual : Operation<(Range,IAdjointable,IAdjointable), QVoid>, ICallable
    {
        public AssertTwoOraclesAreEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Range,IAdjointable,IAdjointable)>, IApplyData
        {
            public In((Range,IAdjointable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AssertTwoOraclesAreEqual";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.AssertTwoOraclesAreEqual";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IAdjointable)> ApplyOracleA
        {
            get;
            set;
        }

        public override Func<(Range,IAdjointable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (nQubits,oracle1,oracle2) = __in__;
#line 35 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var sol = ApplyOracleA.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable)>((__arg1__) => (__arg1__, oracle1)));
#line 36 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var refSol = ApplyOracleA.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable)>((__arg2__) => (__arg2__, oracle2)));
#line 38 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            foreach (var i in nQubits)
#line hidden
            {
#line 39 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
                MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply(((i + 1L), sol, refSol));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.ApplyOracleA = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IAdjointable)>>(typeof(ApplyOracleA));
        }

        public override IApplyData __dataIn((Range,IAdjointable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Range nQubits, IAdjointable oracle1, IAdjointable oracle2)
        {
            return __m__.Run<AssertTwoOraclesAreEqual, (Range,IAdjointable,IAdjointable), QVoid>((nQubits, oracle1, oracle2));
        }
    }

    public partial class AssertTwoOraclesWithOutputArrAreEqual : Operation<(Int64,Int64,IAdjointable,IAdjointable), QVoid>, ICallable
    {
        public AssertTwoOraclesWithOutputArrAreEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,IAdjointable,IAdjointable)>, IApplyData
        {
            public In((Int64,Int64,IAdjointable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "AssertTwoOraclesWithOutputArrAreEqual";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.AssertTwoOraclesWithOutputArrAreEqual";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IAdjointable,Int64)> ApplyOracleWithOutputArrA
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,IAdjointable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (inputSize,outputSize,oracle1,oracle2) = __in__;
#line 49 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var sol = ApplyOracleWithOutputArrA.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable,Int64)>((__arg1__) => (__arg1__, oracle1, outputSize)));
#line 50 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var refSol = ApplyOracleWithOutputArrA.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable,Int64)>((__arg2__) => (__arg2__, oracle2, outputSize)));
#line 51 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply(((inputSize + outputSize), sol, refSol));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.ApplyOracleWithOutputArrA = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IAdjointable,Int64)>>(typeof(ApplyOracleWithOutputArrA));
        }

        public override IApplyData __dataIn((Int64,Int64,IAdjointable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 inputSize, Int64 outputSize, IAdjointable oracle1, IAdjointable oracle2)
        {
            return __m__.Run<AssertTwoOraclesWithOutputArrAreEqual, (Int64,Int64,IAdjointable,IAdjointable), QVoid>((inputSize, outputSize, oracle1, oracle2));
        }
    }

    public partial class Q11_Oracle_CountBits_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Q11_Oracle_CountBits_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Q11_Oracle_CountBits_Test";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.Q11_Oracle_CountBits_Test";
        protected ICallable<(Range,IAdjointable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_CountBits
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_CountBits_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 57 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(1L, 10L), Oracle_CountBits, Oracle_CountBits_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,IAdjointable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.Oracle_CountBits = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_CountBits));
            this.Oracle_CountBits_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_CountBits_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Q11_Oracle_CountBits_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class Q12_Oracle_BitwiseRightShift_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Q12_Oracle_BitwiseRightShift_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Q12_Oracle_BitwiseRightShift_Test";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.Q12_Oracle_BitwiseRightShift_Test";
        protected ICallable<(Int64,Int64,IAdjointable,IAdjointable), QVoid> AssertTwoOraclesWithOutputArrAreEqual
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)> Oracle_BitwiseRightShift
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)> Oracle_BitwiseRightShift_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 63 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            foreach (var n in new Range(2L, 6L))
#line hidden
            {
#line 64 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
                AssertTwoOraclesWithOutputArrAreEqual.Apply((n, n, Oracle_BitwiseRightShift, Oracle_BitwiseRightShift_Reference));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertTwoOraclesWithOutputArrAreEqual = this.Factory.Get<ICallable<(Int64,Int64,IAdjointable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesWithOutputArrAreEqual));
            this.Oracle_BitwiseRightShift = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(Oracle_BitwiseRightShift));
            this.Oracle_BitwiseRightShift_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(Oracle_BitwiseRightShift_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Q12_Oracle_BitwiseRightShift_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class AssertTwoOraclesWithIntArrAreEqual : Operation<(IQArray<Int64>,IAdjointable,IAdjointable), QVoid>, ICallable
    {
        public AssertTwoOraclesWithIntArrAreEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,IAdjointable,IAdjointable)>, IApplyData
        {
            public In((IQArray<Int64>,IAdjointable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AssertTwoOraclesWithIntArrAreEqual";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.AssertTwoOraclesWithIntArrAreEqual";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Range,IAdjointable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,IAdjointable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (A,oracle1,oracle2) = __in__;
#line 71 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(A.Length, A.Length), oracle1.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, A))), oracle2.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, A)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,IAdjointable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
        }

        public override IApplyData __dataIn((IQArray<Int64>,IAdjointable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> A, IAdjointable oracle1, IAdjointable oracle2)
        {
            return __m__.Run<AssertTwoOraclesWithIntArrAreEqual, (IQArray<Int64>,IAdjointable,IAdjointable), QVoid>((A, oracle1, oracle2));
        }
    }

    public partial class Q13_Oracle_OperatorOutput_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Q13_Oracle_OperatorOutput_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Q13_Oracle_OperatorOutput_Test";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.Q13_Oracle_OperatorOutput_Test";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Range,IAdjointable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Int64>,IAdjointable,IAdjointable), QVoid> AssertTwoOraclesWithIntArrAreEqual
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_OperatorOutput
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_OperatorOutput_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 78 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var A = new QArray<Int64>(1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L);
#line 79 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var L = A.Length;
#line 81 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            foreach (var i in new Range(2L, L))
#line hidden
            {
#line 82 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
                AssertTwoOraclesAreEqual.Apply((new Range(i, i), Oracle_OperatorOutput.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, A?.Slice(new Range(0L, (i - 1L)))))), Oracle_OperatorOutput_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, A?.Slice(new Range(0L, (i - 1L))))))));
            }

#line 85 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            A = new QArray<Int64>(1L, 1L, 0L, 0L);
#line 86 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithIntArrAreEqual.Apply((A?.Copy(), Oracle_OperatorOutput, Oracle_OperatorOutput_Reference));
#line 88 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            A = new QArray<Int64>(0L, 0L, 0L, 0L, 0L);
#line 89 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithIntArrAreEqual.Apply((A?.Copy(), Oracle_OperatorOutput, Oracle_OperatorOutput_Reference));
#line 91 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            A = new QArray<Int64>(1L, 0L, 1L, 1L, 1L);
#line 92 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithIntArrAreEqual.Apply((A?.Copy(), Oracle_OperatorOutput, Oracle_OperatorOutput_Reference));
#line 94 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            A = new QArray<Int64>(0L, 1L, 0L, 0L);
#line 95 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithIntArrAreEqual.Apply((A?.Copy(), Oracle_OperatorOutput, Oracle_OperatorOutput_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,IAdjointable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.AssertTwoOraclesWithIntArrAreEqual = this.Factory.Get<ICallable<(IQArray<Int64>,IAdjointable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesWithIntArrAreEqual));
            this.Oracle_OperatorOutput = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_OperatorOutput));
            this.Oracle_OperatorOutput_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_OperatorOutput_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Q13_Oracle_OperatorOutput_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class AssertTwoOraclesWithIntMatrixAreEqual : Operation<(IQArray<IQArray<Int64>>,IAdjointable,IAdjointable), QVoid>, ICallable
    {
        public AssertTwoOraclesWithIntMatrixAreEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Int64>>,IAdjointable,IAdjointable)>, IApplyData
        {
            public In((IQArray<IQArray<Int64>>,IAdjointable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AssertTwoOraclesWithIntMatrixAreEqual";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.AssertTwoOraclesWithIntMatrixAreEqual";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,IAdjointable,IAdjointable), QVoid> AssertTwoOraclesWithOutputArrAreEqual
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Int64>>,IAdjointable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (A,oracle1,oracle2) = __in__;
#line 104 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var inputSize = A[0L].Length;
#line 105 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var outputSize = A.Length;
#line 106 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithOutputArrAreEqual.Apply((inputSize, outputSize, oracle1.Partial(new Func<(IQArray<Qubit>,IQArray<Qubit>), (IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, A))), oracle2.Partial(new Func<(IQArray<Qubit>,IQArray<Qubit>), (IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, A)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.AssertTwoOraclesWithOutputArrAreEqual = this.Factory.Get<ICallable<(Int64,Int64,IAdjointable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesWithOutputArrAreEqual));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Int64>>,IAdjointable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Int64>> A, IAdjointable oracle1, IAdjointable oracle2)
        {
            return __m__.Run<AssertTwoOraclesWithIntMatrixAreEqual, (IQArray<IQArray<Int64>>,IAdjointable,IAdjointable), QVoid>((A, oracle1, oracle2));
        }
    }

    public partial class AssertTwoOraclesWithDifferentOutputsAreEqual : Operation<(Int64,IAdjointable,IAdjointable), QVoid>, ICallable
    {
        public AssertTwoOraclesWithDifferentOutputsAreEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IAdjointable,IAdjointable)>, IApplyData
        {
            public In((Int64,IAdjointable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AssertTwoOraclesWithDifferentOutputsAreEqual";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.AssertTwoOraclesWithDifferentOutputsAreEqual";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IAdjointable)> ApplyOracleA
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IAdjointable,Int64)> ApplyOracleWithOutputArrA
        {
            get;
            set;
        }

        public override Func<(Int64,IAdjointable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (inputSize,oracle1,oracle2) = __in__;
#line 114 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var sol = ApplyOracleWithOutputArrA.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable,Int64)>((__arg1__) => (__arg1__, oracle1, 1L)));
#line 115 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var refSol = ApplyOracleA.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable)>((__arg2__) => (__arg2__, oracle2)));
#line 116 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply(((inputSize + 1L), sol, refSol));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.ApplyOracleA = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IAdjointable)>>(typeof(ApplyOracleA));
            this.ApplyOracleWithOutputArrA = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IAdjointable,Int64)>>(typeof(ApplyOracleWithOutputArrA));
        }

        public override IApplyData __dataIn((Int64,IAdjointable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 inputSize, IAdjointable oracle1, IAdjointable oracle2)
        {
            return __m__.Run<AssertTwoOraclesWithDifferentOutputsAreEqual, (Int64,IAdjointable,IAdjointable), QVoid>((inputSize, oracle1, oracle2));
        }
    }

    public partial class Q14_Oracle_MultidimensionalOperatorOutput_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Q14_Oracle_MultidimensionalOperatorOutput_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Q14_Oracle_MultidimensionalOperatorOutput_Test";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.Q14_Oracle_MultidimensionalOperatorOutput_Test";
        protected ICallable<(Int64,IAdjointable,IAdjointable), QVoid> AssertTwoOraclesWithDifferentOutputsAreEqual
        {
            get;
            set;
        }

        protected ICallable<(IQArray<IQArray<Int64>>,IAdjointable,IAdjointable), QVoid> AssertTwoOraclesWithIntMatrixAreEqual
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,IAdjointable,IAdjointable), QVoid> AssertTwoOraclesWithOutputArrAreEqual
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)> Oracle_BitwiseRightShift_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_CountBits_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)> Oracle_MultidimensionalOperatorOutput
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)> Oracle_MultidimensionalOperatorOutput_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_OperatorOutput_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 122 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var A = new QArray<IQArray<Int64>>(new QArray<Int64>(1L, 1L), new QArray<Int64>(0L, 0L));
#line 123 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithIntMatrixAreEqual.Apply((A?.Copy(), Oracle_MultidimensionalOperatorOutput, Oracle_MultidimensionalOperatorOutput_Reference));
#line 125 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            A = new QArray<IQArray<Int64>>(new QArray<Int64>(1L, 0L), new QArray<Int64>(0L, 1L), new QArray<Int64>(1L, 1L));
#line 126 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithIntMatrixAreEqual.Apply((A?.Copy(), Oracle_MultidimensionalOperatorOutput, Oracle_MultidimensionalOperatorOutput_Reference));
#line 128 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            A = new QArray<IQArray<Int64>>(new QArray<Int64>(0L, 1L, 0L), new QArray<Int64>(1L, 0L, 1L));
#line 129 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithIntMatrixAreEqual.Apply((A?.Copy(), Oracle_MultidimensionalOperatorOutput, Oracle_MultidimensionalOperatorOutput_Reference));
#line 132 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            A = new QArray<IQArray<Int64>>(new QArray<Int64>(0L, 0L, 0L, 0L), new QArray<Int64>(1L, 0L, 0L, 0L), new QArray<Int64>(0L, 1L, 0L, 0L), new QArray<Int64>(0L, 0L, 1L, 0L));
#line 133 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithOutputArrAreEqual.Apply((4L, 4L, Oracle_MultidimensionalOperatorOutput.Partial(new Func<(IQArray<Qubit>,IQArray<Qubit>), (IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, A?.Copy()))), Oracle_BitwiseRightShift_Reference));
#line 136 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var B = new QArray<Int64>(1L, 0L, 1L, 0L, 1L);
#line 137 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithDifferentOutputsAreEqual.Apply((5L, Oracle_MultidimensionalOperatorOutput.Partial(new Func<(IQArray<Qubit>,IQArray<Qubit>), (IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, new QArray<IQArray<Int64>>(B?.Copy())))), Oracle_OperatorOutput_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg3__) => (__arg3__.Item1, __arg3__.Item2, B?.Copy())))));
#line 140 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            B = new QArray<Int64>(1L, 1L, 1L, 1L, 1L);
#line 141 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            AssertTwoOraclesWithDifferentOutputsAreEqual.Apply((5L, Oracle_MultidimensionalOperatorOutput.Partial(new Func<(IQArray<Qubit>,IQArray<Qubit>), (IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>((__arg4__) => (__arg4__.Item1, __arg4__.Item2, new QArray<IQArray<Int64>>(B?.Copy())))), Oracle_CountBits_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertTwoOraclesWithDifferentOutputsAreEqual = this.Factory.Get<ICallable<(Int64,IAdjointable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesWithDifferentOutputsAreEqual));
            this.AssertTwoOraclesWithIntMatrixAreEqual = this.Factory.Get<ICallable<(IQArray<IQArray<Int64>>,IAdjointable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesWithIntMatrixAreEqual));
            this.AssertTwoOraclesWithOutputArrAreEqual = this.Factory.Get<ICallable<(Int64,Int64,IAdjointable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesWithOutputArrAreEqual));
            this.Oracle_BitwiseRightShift_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(Oracle_BitwiseRightShift_Reference));
            this.Oracle_CountBits_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_CountBits_Reference));
            this.Oracle_MultidimensionalOperatorOutput = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>>(typeof(Oracle_MultidimensionalOperatorOutput));
            this.Oracle_MultidimensionalOperatorOutput_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>>(typeof(Oracle_MultidimensionalOperatorOutput_Reference));
            this.Oracle_OperatorOutput_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_OperatorOutput_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Q14_Oracle_MultidimensionalOperatorOutput_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class Q21_StatePrep_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Q21_StatePrep_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Q21_StatePrep_Test";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.Q21_StatePrep_Test";
        protected IUnitary<IQArray<Qubit>> MicrosoftQuantumDiagnosticsAssertAllZero
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> SA_StatePrep
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> SA_StatePrep_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 146 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            foreach (var N in new Range(1L, 10L))
#line hidden
            {
#line hidden
                {
#line 147 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
                    var qs = Allocate.Apply(N);
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 149 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
                        SA_StatePrep.Apply(qs?.Slice(new Range(0L, (N - 1L))));
#line 152 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
                        SA_StatePrep_Reference.Adjoint.Apply(qs?.Slice(new Range(0L, (N - 1L))));
#line 155 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
                        MicrosoftQuantumDiagnosticsAssertAllZero.Apply(qs);
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
                        Release.Apply(qs);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertAllZero = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Diagnostics.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.SA_StatePrep = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(SA_StatePrep));
            this.SA_StatePrep_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(SA_StatePrep_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Q21_StatePrep_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class cs_helper : Operation<(Int64,IQArray<IQArray<Int64>>), (IQArray<Int64>,ICallable)>, ICallable
    {
        public cs_helper(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IQArray<IQArray<Int64>>)>, IApplyData
        {
            public In((Int64,IQArray<IQArray<Int64>>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(IQArray<Int64>,ICallable)>, IApplyData
        {
            public Out((IQArray<Int64>,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "cs_helper";
        String ICallable.FullName => "Quantum.Kata.SimonsAlgorithm.cs_helper";
        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)> Oracle_MultidimensionalOperatorOutput_Reference
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), IQArray<Int64>> Simon_Algorithm
        {
            get;
            set;
        }

        public override Func<(Int64,IQArray<IQArray<Int64>>), (IQArray<Int64>,ICallable)> Body => (__in__) =>
        {
            var (N,Matrix) = __in__;
#line 163 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            var Uf = Oracle_MultidimensionalOperatorOutput_Reference.Partial(new Func<(IQArray<Qubit>,IQArray<Qubit>), (IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, Matrix)));
#line 164 "/Users/arnavgarg/Desktop/QuantumKatas/SimonsAlgorithm/Tests.qs"
            return (Simon_Algorithm.Apply((N, Uf)), Uf);
        }

        ;
        public override void Init()
        {
            this.Oracle_MultidimensionalOperatorOutput_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>>(typeof(Oracle_MultidimensionalOperatorOutput_Reference));
            this.Simon_Algorithm = this.Factory.Get<ICallable<(Int64,ICallable), IQArray<Int64>>>(typeof(Simon_Algorithm));
        }

        public override IApplyData __dataIn((Int64,IQArray<IQArray<Int64>>) data) => new In(data);
        public override IApplyData __dataOut((IQArray<Int64>,ICallable) data) => new Out(data);
        public static System.Threading.Tasks.Task<(IQArray<Int64>,ICallable)> Run(IOperationFactory __m__, Int64 N, IQArray<IQArray<Int64>> Matrix)
        {
            return __m__.Run<cs_helper, (Int64,IQArray<IQArray<Int64>>), (IQArray<Int64>,ICallable)>((N, Matrix));
        }
    }
}