using System;
using System.Collections.Generic;

using datasheetapi;
using datasheetapi.Models;
using datasheetapi.Repositories;

using Xunit;

namespace tests.Repositories;

public class DummyDataTests
{
    public DummyDataTests()
    {
        DummyData.InitializeDummyData();
    }

    [Fact]
    public void TestGetProjects()
    {
        // Arrange
        var expected = new List<Project>
            {
                DummyData.project1
            };

        // Act
        var actual = DummyData.GetProjects();

        // Assert
        Assert.Equal(expected.Count, actual.Count);
        Assert.Equal(expected[0].Id, actual[0].Id);
    }

    [Fact]
    public void TestGetContracts()
    {
        // Arrange
        var expected = new List<Contract>
            {
                DummyData.contract1,
                DummyData.contract2
            };

        // Act
        var actual = DummyData.GetContracts();

        // Assert
        Assert.Equal(expected.Count, actual.Count);
        Assert.Equal(expected[0].Id, actual[0].Id);
        Assert.Equal(expected[1].Id, actual[1].Id);
    }

    [Fact]
    public void TestGetRevisionContainers()
    {
        // Arrange
        var expected = new List<RevisionContainer>
            {
                DummyData.revisionContainerA,
                DummyData.revisionContainerB,
                DummyData.revisionContainerC
            };

        // Act
        var actual = DummyData.GetRevisionContainers();

        // Assert
        Assert.Equal(expected.Count, actual.Count);
        Assert.Equal(expected[0].Id, actual[0].Id);
        Assert.Equal(expected[1].Id, actual[1].Id);
        Assert.Equal(expected[2].Id, actual[2].Id);
    }

    [Fact]
    public void TestAddContractToProjectIfMissing()
    {
        // Arrange
        var contract = new Contract
        {
            Id = Guid.NewGuid(),
            ContractName = "New Contract",
            Project = DummyData.project1
        };

        // Act
        DummyData.AddContractToProjectIfMissing(contract, DummyData.project1);

        // Assert
        Assert.Contains(contract, DummyData.project1.Contracts);
    }

    [Fact]
    public void TestAddRevisionContainerToContractIfMissing()
    {
        // Arrange
        var revisionContainer = new RevisionContainer
        {
            Id = Guid.NewGuid(),
            RevisionNumber = 3,
            RevisionContainerName = "New Container",
            RevisionContainerDate = DateTimeOffset.Now.AddDays(-5),
            Contract = DummyData.contract1
        };

        // Act
        DummyData.AddRevisionContainerToContractIfMissing(revisionContainer, DummyData.contract1);

        // Assert
        Assert.Contains(revisionContainer, DummyData.contract1.RevisionContainers);
    }
}
