using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatrixTests
{



    [Test]
    public void Test_MatrixAddition_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new List<List<int>>()
        {
            new List<int> { 1, 2 },
            new List<int> { 3, 4 }

        };
        List<List<int>> matrixB = new List<List<int>>()
        {
            new List<int> { 1, 1 },
            new List<int> { 1, 1 }

        };

        List<List<int>> expectedResult = new List<List<int>>()
        {
            new List<int> { 2, 3 },
            new List<int> { 4, 5 },
        };

        // Act
        List<List<int>> actualMatrix = Matrix.MatrixAddition(matrixA, matrixB);


        // Assert
        Assert.That(actualMatrix, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_MatrixAddition_EmptyMatrices_ReturnsEmptyMatrix()
    {
        List<List<int>> matrixA = new List<List<int>>();
        List<List<int>> matrixB = new List<List<int>>();

        List<List<int>> expectedResult = new List<List<int>>();
        int expectedResultCount = 0;

        //act

        List<List<int>> actualResult = Matrix.MatrixAddition(matrixA, matrixB);
        int actualResultCount = expectedResult.Count;

        Assert.AreEqual(expectedResultCount, actualResultCount);
        Assert.That(expectedResult, Is.EqualTo(actualResult));


    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_DifferentLength_ThrowsArgumentException()
    {
        //assert 
        //2 rows matrix with 3 columns
        List<List<int>> matrixA = new List<List<int>>()
        {
            new List<int> { 1, 2, 3 },       
            new List<int> { 4, 5, 6 }

        };
        //3 rows matrix with 3 columns
        List<List<int>> matrixB = new List<List<int>>()
        {
            new List<int> { 1, 2, 3, },
            new List<int> { 4, 5, 6, },
            new List<int> { 7, 8, 9, },
        };

        //act + assert

        Assert.Throws<ArgumentException>(() =>
        {
            Matrix.MatrixAddition(matrixA, matrixB);
        }, "Matrices must have the same dimensions for addition.");
        
    }
    [Test]
    public void Test_MatrixAddition_DifferentDimensions_DifferentWidth_ThrowsArgumentException()
    {
        //assert 
        //2 rows matrix with 3 columns
        List<List<int>> matrixA = new List<List<int>>()
        {
            new List<int> { 1, 2,},
            new List<int> { 3 ,4 },
            new List<int> { 5 ,6 }

        };
        //3 rows matrix with 3 columns
        List<List<int>> matrixB = new List<List<int>>()
        {
            new List<int> { 1, 2, 3, },
            new List<int> { 4, 5, 6, },
            new List<int> { 7, 8, 9, },
        };

        //act + assert

        Assert.Throws<ArgumentException>(() =>
        {
            Matrix.MatrixAddition(matrixA, matrixB);
        }, "Matrices must have the same dimensions for addition.");
    }


    [Test]
    public void Test_MatrixAddition_NegativeNumbers_ReturnsCorrectResult()
    {
        List<List<int>> matrixA = new List<List<int>>()
        {
            new List<int> { 1, 2 },
            new List<int> { 3, 4 }

        };
        List<List<int>> matrixB = new List<List<int>>()
        {
            new List<int> { 0, -1 },
            new List<int> { -3, -3 }

        };

        List<List<int>> expectedResult = new List<List<int>>()
        {
            new List<int> { 1, 1 },
            new List<int> { 0, 1 },
        };

        // Act
        List<List<int>> actualMatrix = Matrix.MatrixAddition(matrixA, matrixB);


        // Assert
        Assert.That(actualMatrix, Is.EqualTo(expectedResult));
    }

    // TODO: finish test
    [Test]
    public void Test_MatrixAddition_ZeroMatrix_ReturnsOriginalMatrix()
    {
        List<List<int>> matrixA = new List<List<int>>()
        {
            new List<int> { 1, 2 },
            new List<int> { 3, 4 }

        };
        List<List<int>> matrixZero = new List<List<int>>()
        {
            new List<int> { 0, 0 },
            new List<int> { 0, 0 }

        };


        // Act
        List<List<int>> actualMatrix = Matrix.MatrixAddition(matrixA, matrixZero);


        // Assert
        Assert.That(actualMatrix, Is.EqualTo(matrixA));
    }
}
