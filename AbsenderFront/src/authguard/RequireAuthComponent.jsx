import React from 'react';
import { connect } from 'react-redux';
import { withRouter } from 'react-router-dom'
import { bindActionCreators } from 'redux';
import PropTypes from 'prop-types';
import * as actionCreators from '../_actions';
import Page401 from '../views/Utilities/401';

function mapStateToProps(state) {    
    
    return {
        token: state.auth.token,
        userEmail: state.auth.userEmail,
        isAuthenticated: state.auth.isAuthenticated,
    };
}

function mapDispatchToProps(dispatch) {
    return bindActionCreators(actionCreators, dispatch);
}


export function requireAuthentication(Component) {
    class AuthenticatedComponent extends React.Component {

        state = {
            loaded_if_needed: false
        }

        componentWillMount() {
            this.checkAuth();
        }

        componentWillReceiveProps(nextProps) {
            this.checkAuth(nextProps);
        }

        checkAuth(props = this.props) {
            const token = localStorage.getItem('token');
            if (!token) {
                return props.redirectToRoute('/dashboard');
            } else {
                // validate_token(token)
                //     .then(res => {
                //         if (res.status === 200) {
                //             this.props.loginUserSuccess(token);
                //             this.setState({
                //                 loaded_if_needed: true,
                //             });
                //         } else {
                //             return props.redirectToRoute('/home');
                //         }
                //     }).catch(error => {
                //         return props.redirectToRoute('/home');

                //     });
            }
        }

        render() {
            return (
                <div style={{ width: "100%" }}>
                    {this.props.isAuthenticated && this.state.loaded_if_needed
                        ? <Component {...this.props} />
                        :<Page401/>
                    }
                </div>
            );

        }
    }

    AuthenticatedComponent.propTypes = {
        loginUserSuccess: PropTypes.func,
        isAuthenticated: PropTypes.bool,
    };

    return withRouter(connect(mapStateToProps, mapDispatchToProps)(AuthenticatedComponent));
}
