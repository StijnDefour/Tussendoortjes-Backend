import React, { Component } from 'react';

export class Vrienden extends Component {
    displayName = Vrienden.name

    constructor(props) {
        super(props);
        this.state = { friends: [], loading: true };

        fetch('api/vrienden/index')
            .then(response => response.json())
            .then(data => {
                this.setState({ friends: data, loading: false });
            });
    }

    static renderFriendsTable(friends) {
        console.log(friends);
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Voornaam</th>
                        <th>Achternaam</th>
                        <th>Email</th>
                        <th>Leeftijd</th>
                    </tr>
                </thead>
                <tbody>
                    {friends.map(friend =>
                        <tr key={friend}>
                            <td>{friend.voornaam}</td>
                            <td>{friend.achternaam}</td>
                            <td>{friend.email}</td>
                            <td>{friend.leeftijd}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Vrienden.renderFriendsTable(this.state.friends);

        return (
            <div>
                <h1>Vrienden</h1>
                <p>Deze pagina geeft alle vrienden weer die in de database zitten.</p>
                {contents}
            </div>
        );
    }
}

export class VriendData {
    persoonId: number = 0;
    voornaam: string = "";
    achternaam: string = "";
    leeftijd: number = 0;
    email: string = "";
}    